namespace SitecoreMessagingTopicSample.Messaging
{
    using Sitecore.Framework.Messaging;
    using Sitecore.Pipelines;
    using System;

    public class InitializeSampleMessagingCM
    {
        private readonly IServiceProvider serviceProvider;
        public InitializeSampleMessagingCM(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public void Process(PipelineArgs args)
        {
            this.serviceProvider.StartMessageBus<TopicSampleBus>();
        }
    }
}
