namespace SitecoreMessagingTopicSample.DI
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;
    using SitecoreMessagingTopicSample.Controllers;

    /// <summary>
    /// Registering the DI container
    /// </summary>
    /// <seealso cref="Sitecore.DependencyInjection.IServicesConfigurator"/>
    public class RegisterContainer : IServicesConfigurator
    {
        /// <summary>
        /// Configures the specified service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<MessageTestApiController>();
        }
    }
}
