namespace PersonasEF2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioDeNombreCampoSueldoTablaPersonas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "SueldoNeto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("UPDATE Personas SET SueldoNeto=Sueldo");
            DropColumn("dbo.Personas", "Sueldo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personas", "Sueldo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("UPDATE Personas SET Sueldo=SueldoNeto");
            DropColumn("dbo.Personas", "SueldoNeto");
        }
    }
}
