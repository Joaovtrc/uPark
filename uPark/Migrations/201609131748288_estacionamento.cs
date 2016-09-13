namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estacionamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estacionamentoes",
                c => new
                    {
                        EstacionamentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereço = c.String(),
                        NumeroVagas = c.Int(nullable: false),
                        CNPJ = c.String(),
                        Preço = c.Double(nullable: false),
                        HorarioFuncio = c.DateTime(nullable: false),
                        VagasDisponiveis = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstacionamentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estacionamentoes");
        }
    }
}
