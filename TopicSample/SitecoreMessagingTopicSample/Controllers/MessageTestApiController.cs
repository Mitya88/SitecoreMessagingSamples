namespace SitecoreMessagingTopicSample.Controllers
{
    using Sitecore.Framework.Messaging;
    using Sitecore.Services.Infrastructure.Web.Http;
    using SitecoreMessagingTopicSample.Messaging;
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MessageTestApiController : ServicesApiController
    {
        private readonly IMessageBus<TopicSampleBus> busTopic;

        public MessageTestApiController(IMessageBus<TopicSampleBus> busTopic)
        {
            this.busTopic = busTopic;
        }

        [HttpGet]
        public string Send()
        {
            busTopic.Publish(new SampleMessageContract
            {
                Message = "Hello2",
                Date = DateTime.Now
            });

            return "Sent";
        }
    }
}
