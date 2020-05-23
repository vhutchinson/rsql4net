﻿using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RSql4Net.Configurations;

namespace RSql4Net.Models.Paging
{
    /// <summary>
    ///     Pageable model binder provider.
    /// </summary>
    public class PageableModelBinderProvider : IModelBinderProvider
    {
        private readonly Settings _settings;

        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="T:RSql4Net.Models.Paging.PageableModelBinderProvider" /> class.
        /// </summary>
        /// <param name="settings">Settings.</param>
        public PageableModelBinderProvider(Settings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        /// <summary>
        ///     Gets the binder.
        /// </summary>
        /// <returns>The binder.</returns>
        /// <param name="context">Context.</param>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (!context.Metadata.ModelType.IsGenericType ||
                (context.Metadata.ModelType.GetGenericTypeDefinition() != typeof(IPageable<>) &&
                 context.Metadata.ModelType.GetGenericTypeDefinition() != typeof(Pageable<>)))
            {
                return null;
            }

            var entityType = context.Metadata.ModelType.GetGenericArguments()[0];
            var modelBinderType = typeof(PageableModelBinder<>).MakeGenericType(entityType);
            return (IModelBinder)Activator.CreateInstance(modelBinderType, _settings);
        }
    }
}
