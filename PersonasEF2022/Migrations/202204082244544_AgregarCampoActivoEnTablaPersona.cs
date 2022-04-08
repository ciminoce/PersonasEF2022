namespace PersonasEF2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarCampoActivoEnTablaPersona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Activo", c => c.Boolean(nullable: false));
            Sql("Update Personas SET Activo=0");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personas", "Activo");
        }
    }
}
