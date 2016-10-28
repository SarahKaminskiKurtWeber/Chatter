namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSSL : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chats", "Chats_ChatID", "dbo.Chats");
            DropIndex("dbo.Chats", new[] { "Chats_ChatID" });
            DropColumn("dbo.Chats", "Chats_ChatID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chats", "Chats_ChatID", c => c.Int());
            CreateIndex("dbo.Chats", "Chats_ChatID");
            AddForeignKey("dbo.Chats", "Chats_ChatID", "dbo.Chats", "ChatID");
        }
    }
}
