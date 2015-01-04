namespace SeriesDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialX : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Series", "Actor_Id", "dbo.Actors");
            DropIndex("dbo.Series", new[] { "Actor_Id" });
            RenameColumn(table: "dbo.Series", name: "Actor_Id", newName: "ActorId");
            AddColumn("dbo.Series", "Title", c => c.String());
            AlterColumn("dbo.Series", "ActorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Series", "ActorId");
            AddForeignKey("dbo.Series", "ActorId", "dbo.Actors", "Id", cascadeDelete: true);
            DropColumn("dbo.Series", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Series", "Name", c => c.String());
            DropForeignKey("dbo.Series", "ActorId", "dbo.Actors");
            DropIndex("dbo.Series", new[] { "ActorId" });
            AlterColumn("dbo.Series", "ActorId", c => c.Int());
            DropColumn("dbo.Series", "Title");
            RenameColumn(table: "dbo.Series", name: "ActorId", newName: "Actor_Id");
            CreateIndex("dbo.Series", "Actor_Id");
            AddForeignKey("dbo.Series", "Actor_Id", "dbo.Actors", "Id");
        }
    }
}
