using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdemDeServico.Migrations
{
    /// <inheritdoc />
    public partial class FormServidorUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FormsServidores_Protocolo",
                table: "FormsServidores",
                column: "Protocolo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FormsServidores_Protocolo",
                table: "FormsServidores");
        }
    }
}
