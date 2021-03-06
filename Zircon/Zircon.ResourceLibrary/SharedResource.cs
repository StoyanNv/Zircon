﻿namespace Zircon.ResourceLibrary
{
    using Microsoft.Extensions.Localization;

    public class SharedResource : ISharedResource
    {
        private readonly IStringLocalizer _localizer;

        public SharedResource(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }

        public string this[string index] => _localizer[index];
    }
}