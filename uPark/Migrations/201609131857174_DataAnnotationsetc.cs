namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationsetc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "Carro_CarroId", "dbo.Carroes");
            DropIndex("dbo.Usuarios", new[] { "Carro_CarroId" });
            AddColumn("dbo.Estacionamentoes", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Estacionamentoes", "Senha", c => c.String(nullable: false));
            AddColumn("dbo.Estacionamentoes", "Endereco", c => c.String(nullable: false));
            AddColumn("dbo.Estacionamentoes", "Preco", c => c.Double(nullable: false));
            AlterColumn("dbo.Estacionamentoes", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Estacionamentoes", "CNPJ", c => c.String(nullable: false));
            AlterColumn("dbo.Estacionamentoes", "HorarioFuncio", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Cidade", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Estado", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Carro_CarroId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "Carro_CarroId");
            AddForeignKey("dbo.Usuarios", "Carro_CarroId", "dbo.Carroes", "CarroId", cascadeDelete: true);
            DropColumn("dbo.Estacionamentoes", "Endereço");
            DropColumn("dbo.Estacionamentoes", "Preço");
            DropColumn("dbo.Usuarios", "CEP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "CEP", c => c.Int(nullable: false));
            AddColumn("dbo.Estacionamentoes", "Preço", c => c.Double(nullable: false));
            AddColumn("dbo.Estacionamentoes", "Endereço", c => c.String());
            DropForeignKey("dbo.Usuarios", "Carro_CarroId", "dbo.Carroes");
            DropIndex("dbo.Usuarios", new[] { "Carro_CarroId" });
            AlterColumn("dbo.Usuarios", "Carro_CarroId", c => c.Int());
            AlterColumn("dbo.Usuarios", "Senha", c => c.String());
            AlterColumn("dbo.Usuarios", "Email", c => c.String());
            AlterColumn("dbo.Usuarios", "Estado", c => c.String());
            AlterColumn("dbo.Usuarios", "Cidade", c => c.String());
            AlterColumn("dbo.Usuarios", "Nome", c => c.String());
            AlterColumn("dbo.Estacionamentoes", "HorarioFuncio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Estacionamentoes", "CNPJ", c => c.String());
            AlterColumn("dbo.Estacionamentoes", "Nome", c => c.String());
            DropColumn("dbo.Estacionamentoes", "Preco");
            DropColumn("dbo.Estacionamentoes", "Endereco");
            DropColumn("dbo.Estacionamentoes", "Senha");
            DropColumn("dbo.Estacionamentoes", "Email");
            CreateIndex("dbo.Usuarios", "Carro_CarroId");
            AddForeignKey("dbo.Usuarios", "Carro_CarroId", "dbo.Carroes", "CarroId");
        }
    }
}
