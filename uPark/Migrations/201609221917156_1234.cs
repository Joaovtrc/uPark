namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Carroes");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                {
                    CarroId = c.Int(nullable: false, identity: true),
                    Marca = c.String(nullable: false),
                    Modelo = c.String(nullable: false),
                    Cor = c.String(nullable: false),
                    Placa = c.String(nullable: false),
                })
                .PrimaryKey(t => t.CarroId);

        }
    }
}
