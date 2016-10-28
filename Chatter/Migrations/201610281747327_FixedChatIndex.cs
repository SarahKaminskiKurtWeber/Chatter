namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedChatIndex : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chats", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chats", "UserName");
        }
    }
}
