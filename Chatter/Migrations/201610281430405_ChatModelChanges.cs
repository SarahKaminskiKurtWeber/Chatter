namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatModelChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatText",
                c => new
                    {
                        ChatID = c.Int(nullable: false, identity: true),
                        ChatText = c.String(),
                        ChatUserName = c.String(),
                        ApplicationUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ChatID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUsers_Id)
                .Index(t => t.ApplicationUsers_Id);
            
            AddColumn("dbo.AspNetUsers", "IdentityID", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "IdentityUserName", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChatText", "ApplicationUsers_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ChatText", new[] { "ApplicationUsers_Id" });
            DropColumn("dbo.AspNetUsers", "IdentityUserName");
            DropColumn("dbo.AspNetUsers", "IdentityID");
            DropTable("dbo.ChatText");
        }
    }
}
