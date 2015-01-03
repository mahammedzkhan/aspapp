namespace SeriesDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Street = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Series", "Actor_Id", c => c.Int());
            CreateIndex("dbo.Series", "Actor_Id");
            AddForeignKey("dbo.Series", "Actor_Id", "dbo.Actors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "Actor_Id", "dbo.Actors");
            DropIndex("dbo.Series", new[] { "Actor_Id" });
            DropColumn("dbo.Series", "Actor_Id");
            DropTable("dbo.Actors");
        }
    }
}
