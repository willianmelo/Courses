using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ProjLoja;

namespace ProjLoja.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    [Migration("20170314234310_CriaProdutoECategoria")]
    partial class CriaProdutoECategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjLoja.Entidades.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("ProjLoja.Entidades.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("ProjLoja.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ProjLoja.Entidades.Produto", b =>
                {
                    b.HasOne("ProjLoja.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });
        }
    }
}
