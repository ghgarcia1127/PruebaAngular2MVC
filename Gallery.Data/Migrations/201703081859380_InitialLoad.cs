namespace Gallery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialLoad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collections",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Paintings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total_in_Shelf = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total_in_Vault = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Collection_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collections", t => t.Collection_Id, cascadeDelete: true)
                .Index(t => t.Collection_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paintings", "Collection_Id", "dbo.Collections");
            DropIndex("dbo.Paintings", new[] { "Collection_Id" });
            DropTable("dbo.Paintings");
            DropTable("dbo.Collections");
        }
    }
}
