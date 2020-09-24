namespace SitecoreMessagingTopicSample.Messaging
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;
    using Sitecore.Framework.Messaging;

    public class TopicSampleReceiverConfiguration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMessageHandler<SampleMessageContract>, TopicMessageHandler>();
        }
    }
}
