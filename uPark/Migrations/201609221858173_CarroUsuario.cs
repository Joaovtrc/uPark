namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarroUsuario : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Usuarios", name: "Carro_CarroId", newName: "CarroId");
            RenameIndex(table: "dbo.Usuarios", name: "IX_Carro_CarroId", newName: "IX_CarroId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Usuarios", name: "IX_CarroId", newName: "IX_Carro_CarroId");
            RenameColumn(table: "dbo.Usuarios", name: "CarroId", newName: "Carro_CarroId");
        }
    }
}
