namespace SemanaTecnologiaEvolucao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniciandonovamente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoFaculdade = c.String(),
                        UserName = c.String(),
                        Senha = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
