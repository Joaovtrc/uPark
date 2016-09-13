namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Cor = c.String(),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.CarroId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNasc = c.DateTime(nullable: false),
                        CPF = c.Int(nullable: false),
                        CEP = c.Int(nullable: false),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Carro_CarroId = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Carroes", t => t.Carro_CarroId)
                .Index(t => t.Carro_CarroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Carro_CarroId", "dbo.Carroes");
            DropIndex("dbo.Usuarios", new[] { "Carro_CarroId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Carroes");
        }
    }
}
