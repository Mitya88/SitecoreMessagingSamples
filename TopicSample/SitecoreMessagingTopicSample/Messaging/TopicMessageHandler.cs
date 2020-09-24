namespace SitecoreMessagingTopicSample.Messaging
{
    using Sitecore.Framework.Messaging;
    using System.Threading.Tasks;

    public class TopicMessageHandler : IMessageHandler<SampleMessageContract>
    {
        public TopicMessageHandler()
        {

        }

        public Task Handle(SampleMessageContract message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
        {
            //Log the incoming message
            Sitecore.Diagnostics.Log.Info($"Message Received: {message.Message}, {message.Date}", this);

            // Implement your business logic

            return Task.CompletedTask;
        }
    }
}
