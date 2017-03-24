using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using lojaComEntity.Entitades;

namespace lojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170324201343_tiposUsuario")]
    partial class tiposUsuario
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

            modelBuilder.Entity("lojaComEntity.Entitades.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("VendaID", "ProdutoID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "Usuario");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientID");

                    b.Property<int?>("clienteID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.PessoaFisica", b =>
                {
                    b.HasBaseType("lojaComEntity.Entitades.Usuario");

                    b.Property<string>("CPF");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaFisica");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.PessoaJuridica", b =>
                {
                    b.HasBaseType("lojaComEntity.Entitades.Usuario");

                    b.Property<string>("CNPJ");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaJuridica");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Produto", b =>
                {
                    b.HasOne("lojaComEntity.Entitades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.ProdutoVenda", b =>
                {
                    b.HasOne("lojaComEntity.Entitades.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.HasOne("lojaComEntity.Entitades.Venda")
                        .WithMany()
                        .HasForeignKey("VendaID");
                });

            modelBuilder.Entity("lojaComEntity.Entitades.Venda", b =>
                {
                    b.HasOne("lojaComEntity.Entitades.Usuario")
                        .WithMany()
                        .HasForeignKey("clienteID");
                });
        }
    }
}
