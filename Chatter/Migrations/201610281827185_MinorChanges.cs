namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chats", "ChatText", c => c.String());
            DropColumn("dbo.Chats", "Chats");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chats", "Chats", c => c.String());
            DropColumn("dbo.Chats", "ChatText");
        }
    }
}
