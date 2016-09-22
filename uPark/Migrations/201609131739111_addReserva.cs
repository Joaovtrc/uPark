namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReserva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ReservaId = c.Int(nullable: false, identity: true),
                        UsuarioID = c.Int(nullable: false),
                        DataReserva = c.DateTime(nullable: false),
                        HorarioEntrara = c.DateTime(nullable: false),
                        HorarioSaida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaId);
            
            AddColumn("dbo.Usuarios", "ReservaUsuario_ReservaId", c => c.Int());
            CreateIndex("dbo.Usuarios", "ReservaUsuario_ReservaId");
            AddForeignKey("dbo.Usuarios", "ReservaUsuario_ReservaId", "dbo.Reservas", "ReservaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "ReservaUsuario_ReservaId", "dbo.Reservas");
            DropIndex("dbo.Usuarios", new[] { "ReservaUsuario_ReservaId" });
            DropColumn("dbo.Usuarios", "ReservaUsuario_ReservaId");
            DropTable("dbo.Reservas");
        }
    }
}
