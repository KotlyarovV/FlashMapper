using System;

namespace FlashMapper.Internal.Utils
{
    [Obsolete]
    public class FlashMapperCustomServiceBuilderFactory : IFlashMapperCustomServiceBuilderFactory
    {
        private readonly IFlashMapperDependencyResolver dependencyResolver;

        public FlashMapperCustomServiceBuilderFactory(IFlashMapperDependencyResolver dependencyResolver)
        {
            this.dependencyResolver = dependencyResolver;
        }

        public IFlashMapperCustomServiceBuilder Create()
        {
            return new FlashMapperCustomServiceBuilder(dependencyResolver);
        }
    }
}