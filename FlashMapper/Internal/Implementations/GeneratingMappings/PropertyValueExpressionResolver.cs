using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FlashMapper.Models;
using FlashMapper.Services.GeneratingMappings;
using FlashMapper.Services.MatchingProperties;

namespace FlashMapper.Internal.Implementations.GeneratingMappings
{
    public class PropertyValueExpressionResolver : IPropertyValueExpressionResolver
    {
        private readonly IFlashMapperSettings settings;
        private readonly IEnumerable<ISpecificPropertyValueExpressionResolver> specificResolvers;

        public PropertyValueExpressionResolver(IEnumerable<ISpecificPropertyValueExpressionResolver> specificResolvers,
            IFlashMapperSettings settings)
        {
            this.settings = settings;
            this.specificResolvers = specificResolvers.ToArray();
        }

        private Expression GetIgnoreExpression(Type propertyType)
        {
            var ignoreMethodInfo = typeof(MappingOptions).GetMethods()
                .First(m => m.Name == nameof(MappingOptions.Ignore) && m.IsGenericMethod)
                .MakeGenericMethod(propertyType);
            return Expression.Call(null, ignoreMethodInfo);
        }

        public Expression GetPropertyValueExpression<TSource, TDestination>(ParameterExpression source, 
            PropertyInfo property, 
            MemberBinding[] userBindings)
        {
            Expression result = null;
            if (specificResolvers.Any(r => r.TryGetPropertyValueExpression<TSource, TDestination>(source, property, userBindings, out result)))
                return result;

            if (settings.UnresolvedBehavior == UnresolvedPropertyBehavior.Ignore)
                return GetIgnoreExpression(property.PropertyType);

            throw new PropertyIsNotMappedException(property.Name, $"Mapping is not specified for property {property.Name} of type {typeof(TDestination).Name}.");
        }
    }
}