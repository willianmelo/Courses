namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Senha = c.String(),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Usuarios", new[] { "Categoria_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Categorias");
        }
    }
}
