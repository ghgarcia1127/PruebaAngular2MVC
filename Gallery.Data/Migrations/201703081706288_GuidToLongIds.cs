namespace Gallery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuidToLongIds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Paintings", "Collection_Id", "dbo.Collections");
            DropIndex("dbo.Paintings", new[] { "Collection_Id" });
            DropPrimaryKey("dbo.Collections");
            DropPrimaryKey("dbo.Paintings");
            AlterColumn("dbo.Collections", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Paintings", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Paintings", "Collection_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Collections", "Id");
            AddPrimaryKey("dbo.Paintings", "Id");
            CreateIndex("dbo.Paintings", "Collection_Id");
            AddForeignKey("dbo.Paintings", "Collection_Id", "dbo.Collections", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paintings", "Collection_Id", "dbo.Collections");
            DropIndex("dbo.Paintings", new[] { "Collection_Id" });
            DropPrimaryKey("dbo.Paintings");
            DropPrimaryKey("dbo.Collections");
            AlterColumn("dbo.Paintings", "Collection_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Paintings", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Collections", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Paintings", "Id");
            AddPrimaryKey("dbo.Collections", "Id");
            CreateIndex("dbo.Paintings", "Collection_Id");
            AddForeignKey("dbo.Paintings", "Collection_Id", "dbo.Collections", "Id", cascadeDelete: true);
        }
    }
}
