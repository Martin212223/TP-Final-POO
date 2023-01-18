namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aviones",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominacion = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineasAereas", t => t.IdLinea, cascadeDelete: true)
                .Index(t => t.IdLinea);
            
            CreateTable(
                "dbo.LineasAereas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aviones", "IdLinea", "dbo.LineasAereas");
            DropIndex("dbo.Aviones", new[] { "IdLinea" });
            DropTable("dbo.LineasAereas");
            DropTable("dbo.Aviones");
        }
    }
}
