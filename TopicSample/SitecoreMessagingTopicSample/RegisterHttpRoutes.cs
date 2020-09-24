namespace SitecoreMessagingTopicSample
{
    using Sitecore.Pipelines;
    using System.Web.Http;
    using System.Web.Routing;

    public class RegisterHttpRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RegisterRoute(RouteTable.Routes);
        }

        protected virtual void RegisterRoute(RouteCollection routes)
        {
            RouteTable.Routes.MapHttpRoute("MessageTestApi",
                "api/MessageTestApi/{action}",
                new { controller = "MessageTestApi" });
        }
    }
}
