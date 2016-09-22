namespace uPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DACarro : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carroes", "Marca", c => c.String(nullable: false));
            AlterColumn("dbo.Carroes", "Modelo", c => c.String(nullable: false));
            AlterColumn("dbo.Carroes", "Cor", c => c.String(nullable: false));
            AlterColumn("dbo.Carroes", "Placa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carroes", "Placa", c => c.String());
            AlterColumn("dbo.Carroes", "Cor", c => c.String());
            AlterColumn("dbo.Carroes", "Modelo", c => c.String());
            AlterColumn("dbo.Carroes", "Marca", c => c.String());
        }
    }
}
