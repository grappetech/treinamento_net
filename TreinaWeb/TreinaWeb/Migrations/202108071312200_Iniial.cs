namespace TreinaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        Reponsavel = c.String(maxLength: 200),
                        Data = c.DateTime(nullable: false),
                        Prazo = c.DateTime(),
                        FinalizadoEm = c.DateTime(),
                        Descricao = c.String(),
                        Finalizado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
