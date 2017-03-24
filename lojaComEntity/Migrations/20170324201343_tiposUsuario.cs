using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace lojaComEntity.Migrations
{
    public partial class tiposUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaID", table: "ProdutoVenda");
            migrationBuilder.DropColumn(name: "CPNJ", table: "Usuario");
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoID",
                table: "ProdutoVenda",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaID",
                table: "ProdutoVenda",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaID", table: "ProdutoVenda");
            migrationBuilder.DropColumn(name: "CNPJ", table: "Usuario");
            migrationBuilder.AddColumn<int>(
                name: "CPNJ",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoID",
                table: "ProdutoVenda",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaID",
                table: "ProdutoVenda",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
