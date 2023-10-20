namespace EventFlow.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EventFlow.Data.EventFlowDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EventFlow.Data.EventFlowDB";
        }

        protected override void Seed(EventFlow.Data.EventFlowDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
