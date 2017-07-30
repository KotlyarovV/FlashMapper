using System;
using System.Collections.Generic;
using System.Linq;

namespace FlashMapper.DependancyInjection
{
    internal class MappingConfigStepHandler : IMappingConfigStepHandler
    {
        private readonly IEnumerable<ISpecificMappingConfigStepHandler> specificHandlers;

        public MappingConfigStepHandler(IEnumerable<ISpecificMappingConfigStepHandler> specificHandlers)
        {
            this.specificHandlers = specificHandlers;
        }

        public void ProcessStep<TBuilder>(IMappingConfigStep step, TBuilder builder, IMappingConfiguration currentMappingConfiguration,
            IMappingConfiguration previousMappingConfiguration, DeferredFlashMapperSettingsBuilder settingsBuilder)
        {
            if (!specificHandlers.Any(h => h.TryProcessStep(step, builder, currentMappingConfiguration, previousMappingConfiguration, settingsBuilder)))
                throw new Exception($"No handler was found to process step {step?.GetType().Name}.");
        }
    }
}