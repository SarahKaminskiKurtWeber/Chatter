namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatText", "ChatText", c => c.String());
            DropColumn("dbo.ChatText", "ChatText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChatText", "ChatText", c => c.String());
            DropColumn("dbo.ChatText", "ChatText");
        }
    }
}
