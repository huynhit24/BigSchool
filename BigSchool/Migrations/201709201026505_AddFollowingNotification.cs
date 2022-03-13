namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingNotification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FollowingNotifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logger = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FollowingNotifications");
        }
    }
}
