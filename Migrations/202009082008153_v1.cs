namespace MarketAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Categoria = c.String(nullable: false, maxLength: 10),
                        PreTitulo = c.String(maxLength: 15),
                        Titulo = c.String(nullable: false, maxLength: 30),
                        Imagem = c.String(),
                        Endereco = c.String(nullable: false),
                        EnderecoId = c.Int(nullable: false),
                        Possui360 = c.Boolean(nullable: false),
                        EFavorita = c.Boolean(nullable: false),
                        Avaliacao = c.Short(nullable: false),
                        Descricao = c.String(maxLength: 500),
                        Capacidade = c.Int(nullable: false),
                        Hora = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Diaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Codigo = c.String(nullable: false),
                        EstaReservado = c.Boolean(nullable: false),
                        ESelecionado = c.Boolean(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecos", t => t.EnderecoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.EnderecoId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(nullable: false, maxLength: 8),
                        Estado = c.String(),
                        CidadeMunicipio = c.String(),
                        NomeDoEdificio = c.String(nullable: false, maxLength: 30),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Complemento = c.String(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Source = c.String(nullable: false),
                        AnuncioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Anuncios", t => t.AnuncioId, cascadeDelete: true)
                .Index(t => t.AnuncioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Telefone = c.String(nullable: false, maxLength: 14),
                        CartaoId = c.Int(nullable: false),
                        EAdministrador = c.Boolean(nullable: false),
                        FotoPerfil_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Imagens", t => t.FotoPerfil_Id)
                .Index(t => t.FotoPerfil_Id);
            
            CreateTable(
                "dbo.Calendarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnuncioId = c.Int(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Anuncios", t => t.AnuncioId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.AnuncioId)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Datas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        CalendarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendarios", t => t.CalendarioId, cascadeDelete: true)
                .Index(t => t.CalendarioId);
            
            CreateTable(
                "dbo.Cartoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroCartao = c.String(nullable: false, maxLength: 4),
                        Titular = c.String(nullable: false, maxLength: 40),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "FotoPerfil_Id", "dbo.Imagens");
            DropForeignKey("dbo.Cartoes", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Calendarios", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Datas", "CalendarioId", "dbo.Calendarios");
            DropForeignKey("dbo.Calendarios", "AnuncioId", "dbo.Anuncios");
            DropForeignKey("dbo.Anuncios", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Imagens", "AnuncioId", "dbo.Anuncios");
            DropForeignKey("dbo.Anuncios", "EnderecoId", "dbo.Enderecos");
            DropIndex("dbo.Cartoes", new[] { "UsuarioId" });
            DropIndex("dbo.Datas", new[] { "CalendarioId" });
            DropIndex("dbo.Calendarios", new[] { "Usuario_Id" });
            DropIndex("dbo.Calendarios", new[] { "AnuncioId" });
            DropIndex("dbo.Usuarios", new[] { "FotoPerfil_Id" });
            DropIndex("dbo.Imagens", new[] { "AnuncioId" });
            DropIndex("dbo.Anuncios", new[] { "UsuarioId" });
            DropIndex("dbo.Anuncios", new[] { "EnderecoId" });
            DropTable("dbo.Cartoes");
            DropTable("dbo.Datas");
            DropTable("dbo.Calendarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Imagens");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Anuncios");
        }
    }
}
