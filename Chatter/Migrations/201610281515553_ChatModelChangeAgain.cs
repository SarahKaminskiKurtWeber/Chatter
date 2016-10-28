namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatModelChangeAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatText", "ChatText_ChatID", c => c.Int());
            CreateIndex("dbo.ChatText", "ChatText_ChatID");
            AddForeignKey("dbo.ChatText", "ChatText_ChatID", "dbo.ChatText", "ChatID");
            DropColumn("dbo.ChatText", "ChatUserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChatText", "ChatUserName", c => c.String());
            DropForeignKey("dbo.ChatText", "ChatText_ChatID", "dbo.ChatText");
            DropIndex("dbo.ChatText", new[] { "ChatText_ChatID" });
            DropColumn("dbo.ChatText", "ChatText_ChatID");
        }
    }
}
