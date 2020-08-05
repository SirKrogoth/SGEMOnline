using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGEMOnline.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Estoque = table.Column<double>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itens");
        }
    }
}
