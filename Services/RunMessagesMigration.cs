using Crito.Context;
using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Migrations;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Migrations.Upgrade;

namespace Crito.Services
{
    public class RunMessagesMigration : INotificationAsyncHandler<UmbracoApplicationStartedNotification>
    {
        private readonly DataContext _dataContext;

        public RunMessagesMigration(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task HandleAsync(UmbracoApplicationStartedNotification notification, CancellationToken cancellationToken)
        {
            IEnumerable<string> pendingMigrations = await _dataContext.Database.GetPendingMigrationsAsync();

            if(pendingMigrations.Any())
            {
                await _dataContext.Database.MigrateAsync();
            }
        }
    }
}
