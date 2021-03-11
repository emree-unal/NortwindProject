using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.CrossCuttingConcerns.Caching;
using YazılımKampıKatmanlıMimari.Core.CrossCuttingConcerns.Caching.Microsoft;
using YazılımKampıKatmanlıMimari.Core.Utilities.IoC;

namespace YazılımKampıKatmanlıMimari.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
