namespace SitecoreMessagingTopicSample.Messaging
{
    using Sitecore.DependencyInjection;
    using Sitecore.Framework.Messaging;
    using Sitecore.Pipelines;
    using System;

    public class InitializeSampleMessagingCD
    {
        private readonly IServiceProvider serviceProvider;

        private readonly IMessageBus messageBus;
        public InitializeSampleMessagingCD(IServiceProvider serviceProvider, IMessageBus<TopicSampleBus> messageBus)
        {
            this.serviceProvider = serviceProvider;
            this.messageBus = messageBus;
        }
        public void Process(PipelineArgs args)
        {
            this.serviceProvider.StartMessageBus<TopicSampleBus>();
            messageBus.Subscribe<SampleMessageContract>();

        }
    }
}
