using System.Web.Http;

namespace Papercut.WebUI
{
    using Autofac;
    using Autofac.Integration.WebApi;

    public static class RouteConfig
    {
        public static void Init(HttpConfiguration config, ILifetimeScope scope)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(scope);
            config.Routes.MapHttpRoute("health", "health", new {controller = "Health"});

            config.Routes.MapHttpRoute("load all messages", "messages", new {controller = "Message", action = "GetAll"});
            config.Routes.MapHttpRoute("load message detail", "messages/{id}", new { controller = "Message", action = "Get" });
        }
    }
}