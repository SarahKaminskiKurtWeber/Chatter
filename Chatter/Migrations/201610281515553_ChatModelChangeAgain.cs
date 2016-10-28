namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatModelChangeAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chats", "Chats_ChatID", c => c.Int());
            CreateIndex("dbo.Chats", "Chats_ChatID");
            AddForeignKey("dbo.Chats", "Chats_ChatID", "dbo.Chats", "ChatID");
            DropColumn("dbo.Chats", "ChatUserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chats", "ChatUserName", c => c.String());
            DropForeignKey("dbo.Chats", "Chats_ChatID", "dbo.Chats");
            DropIndex("dbo.Chats", new[] { "Chats_ChatID" });
            DropColumn("dbo.Chats", "Chats_ChatID");
        }
    }
}
