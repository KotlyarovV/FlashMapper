﻿// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
using System;
using System.Linq.Expressions;

namespace FlashMapper.DependancyInjection
{
    internal class FlashMapperBuilderConfigurator<TSource1, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TDestination> ResolveExtraParameter<TSource2>(Expression<Func<TSource1, TSource2>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TDestination> ResolveExtraParameter<TSource3>(Expression<Func<TSource1, TSource2, TSource3>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TDestination> ResolveExtraParameter<TSource4>(Expression<Func<TSource1, TSource2, TSource3, TSource4>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TDestination> ResolveExtraParameter<TSource5>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TDestination> ResolveExtraParameter<TSource6>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TDestination> ResolveExtraParameter<TSource7>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TDestination> ResolveExtraParameter<TSource8>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TDestination> ResolveExtraParameter<TSource9>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TDestination> ResolveExtraParameter<TSource10>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TDestination> ResolveExtraParameter<TSource11>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TDestination> ResolveExtraParameter<TSource12>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TDestination> ResolveExtraParameter<TSource13>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

		public IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TDestination> ResolveExtraParameter<TSource14>(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14>> resolveParameterMethod)
		{
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			Func<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TBuilder, TDestination> convertMethod = FlashMapperMultiSourceExtensions.Convert<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TBuilder, TDestination>;
			Action<IMappingConfiguration, TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TBuilder, TDestination> mapDataMethod = FlashMapperMultiSourceExtensions.MapData;
			var step = new ResolveExtraParameterStep(resolveParameterMethod, convertMethod.Method, mapDataMethod.Method, createMappingMethod.Method);
			context.Steps.Add(step);
			return new FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TDestination, TBuilder>(context);
		}
        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

    internal class FlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TDestination, TBuilder> : IFlashMapperBuilderConfigurator<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TDestination>
    {
        private readonly IFlashMapperBuilderConfiguratorContext context;
        public FlashMapperBuilderConfigurator(IFlashMapperBuilderConfiguratorContext context)
        {
            this.context = context;
        }

        public IFlashMapperSettingsBuilder CreateMapping(Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TDestination>> mappingExpression)
        {
			Action<IMappingConfiguration, Expression<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TBuilder, TDestination>>, Func<IFlashMapperSettingsBuilder, IFlashMapperSettingsBuilder>, Func<IFlashMapperCustomServiceBuilder, IFlashMapperCustomServiceBuilder>> createMappingMethod = FlashMapperMultiSourceExtensions.CreateMapping;
			var step = new ResultMappingConfigStep(mappingExpression, createMappingMethod.Method);
			context.Steps.Add(step);
            return context.SettingsBuilder;
        }
    }

	
	internal delegate void Action<in T1,in T2,in T3,in T4,in T5,in T6,in T7,in T8,in T9,in T10,in T11,in T12,in T13,in T14,in T15,in T16,in T17>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17);
}