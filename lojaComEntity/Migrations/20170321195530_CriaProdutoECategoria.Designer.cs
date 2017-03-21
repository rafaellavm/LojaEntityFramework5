using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using lojaComEntity.Entitades;

namespace lojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170321195530_CriaProdutoECategoria")]
    partial class CriaProdutoECategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lojaComEntity.Entitades.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Produto", b =>
                {
                    b.HasOne("lojaComEntity.Entitades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });
        }
    }
}
