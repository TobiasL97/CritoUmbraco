using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace Crito.Services
{
    public class MessageComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder) => builder.AddNotificationAsyncHandler<UmbracoApplicationStartedNotification, RunMessagesMigration>();
        
    }
}
