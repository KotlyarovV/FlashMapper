using System;
using System.Linq.Expressions;
using FlashMapper.Models;

namespace FlashMapper.Services.GeneratingMappings
{
    public interface IMappingExpressionAutocompleteService: IFlashMapperService
    {
        Expression<Func<TSource, TDestination>> CompleteBuildExpression<TSource, TDestination>(Expression<Func<TSource, TDestination>> inputExpression, IFlashMapperMappingCallbacks<TSource, TDestination> callbacks);
        Expression<Action<TSource, TDestination>> CompleteMapDataExpression<TSource, TDestination>(Expression<Func<TSource, TDestination>> inputExpression, IFlashMapperMappingCallbacks<TSource, TDestination> callbacks);
    }
}