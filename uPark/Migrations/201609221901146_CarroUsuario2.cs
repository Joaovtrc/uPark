namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarroUsuario2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "CarroId", "dbo.Carroes");
            DropIndex("dbo.Usuarios", new[] { "CarroId" });
            DropColumn("dbo.Usuarios", "CarroId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "CarroId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "CarroId");
            AddForeignKey("dbo.Usuarios", "CarroId", "dbo.Carroes", "CarroId", cascadeDelete: true);
        }
    }
}
