using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Business.Concrete;
using YazılımKampıKatmanlıMimari.Core.Utilities.Interceptors;
using YazılımKampıKatmanlıMimari.DataAccess.Abstract;
using YazılımKampıKatmanlıMimari.DataAccess.Concrete.EntityFramework;

namespace YazılımKampıKatmanlıMimari.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //içinde data taşımadığı için tek instance ürenten yapı için singleton kullandık.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
