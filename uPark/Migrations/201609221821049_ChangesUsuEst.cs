namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesUsuEst : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "ReservaUsuario_ReservaId", "dbo.Reservas");
            DropIndex("dbo.Usuarios", new[] { "ReservaUsuario_ReservaId" });
            AlterColumn("dbo.Usuarios", "DataNasc", c => c.String(nullable: false));
            DropColumn("dbo.Estacionamentoes", "VagasDisponiveis");
            DropColumn("dbo.Usuarios", "Cidade");
            DropColumn("dbo.Usuarios", "Estado");
            DropColumn("dbo.Usuarios", "ReservaUsuario_ReservaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "ReservaUsuario_ReservaId", c => c.Int());
            AddColumn("dbo.Usuarios", "Estado", c => c.String(nullable: false));
            AddColumn("dbo.Usuarios", "Cidade", c => c.String(nullable: false));
            AddColumn("dbo.Estacionamentoes", "VagasDisponiveis", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "DataNasc", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Usuarios", "ReservaUsuario_ReservaId");
            AddForeignKey("dbo.Usuarios", "ReservaUsuario_ReservaId", "dbo.Reservas", "ReservaId");
        }
    }
}
