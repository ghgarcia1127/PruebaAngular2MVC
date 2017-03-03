namespace Gallery.Data.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gallery.Data.GalleryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Gallery.Data.GalleryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            SetCollections(context);
        }

        private void SetCollections(GalleryContext context)
        {
            context.GetSet<Collection>().AddOrUpdate(C => C.Id,
                new Collection { Id = Guid.NewGuid(), Name = "Paisagismo", Date = new DateTime(2017,02,28) },
                new Collection { Id = Guid.NewGuid(), Name = "Bodegon", Date = new DateTime(2017, 02, 28) });
        }
    }
}
