namespace PersonasEF2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Sueldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
