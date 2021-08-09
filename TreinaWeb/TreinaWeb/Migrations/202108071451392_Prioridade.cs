namespace TreinaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prioridade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Prioridade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Prioridade");
        }
    }
}
