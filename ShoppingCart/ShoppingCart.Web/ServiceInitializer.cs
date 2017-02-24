using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using SimpleInjector;
//using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using ShoppingCart.Services.Interfaces;
using ShoppingCart.Services;

namespace ShoppingCart.Web
{
    public class ServiceInitializer
    {
        public void Initialize()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register<IShoppingCartService,ShoppingCartService>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}