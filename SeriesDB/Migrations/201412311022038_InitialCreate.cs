namespace SeriesDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
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
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);

            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "GenreId", "dbo.Genres");
            DropIndex("dbo.Series", new[] { "GenreId" });
            DropColumn("dbo.Series", "Actor_Id");
            DropTable("dbo.Actors");
            DropTable("dbo.Genres");
        }
    }
}
