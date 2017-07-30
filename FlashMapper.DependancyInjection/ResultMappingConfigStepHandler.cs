using System;
using System.Linq.Expressions;

namespace FlashMapper.DependancyInjection
{
    internal class ResultMappingConfigStepHandler : ISpecificMappingConfigStepHandler
    {
        private LambdaExpression MakeExpressionStatic<TBuilder>(LambdaExpression inputExpression, TBuilder builderInstance)
        {
            var builderParameter = Expression.Parameter(typeof(TBuilder));
            var toStaticMethodVisitor = new ToStaticMethodVisitor(builderInstance, builderParameter);
            var staticMethodBody = toStaticMethodVisitor.Visit(inputExpression.Body);
            return Expression.Lambda(staticMethodBody,
                inputExpression.Parameters.With(builderParameter));
        }

        public bool TryProcessStep<TBuilder>(IMappingConfigStep step, 
            TBuilder builder,
            IMappingConfiguration currentMappingConfiguration, 
            IMappingConfiguration previousMappingConfiguration,
            DeferredFlashMapperSettingsBuilder settingsBuilder)
        {
            var resultMappingConfigStep = step as ResultMappingConfigStep;
            if (resultMappingConfigStep == null)
                return false;
            Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder> settings = settingsBuilder.Initialize;
            Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder> customServicesRegistration = c => c;
            var staticResultExpression = MakeExpressionStatic(resultMappingConfigStep.ResultExpression, builder);
            resultMappingConfigStep.CreateMappingMethod.Invoke(null, new object[]
            {
                currentMappingConfiguration,
                staticResultExpression,
                settings,
                customServicesRegistration
            });
            return true;
        }
    }
}