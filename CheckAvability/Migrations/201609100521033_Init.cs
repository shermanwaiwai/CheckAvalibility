namespace CheckAvability.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IphonePlus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                        Model = c.String(),
                        createTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IphonePlus");
        }
    }
}
