using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radi_Administracija_Administracija_FK",
                table: "Radi");

            migrationBuilder.DropForeignKey(
                name: "FK_Radi_Profesor_ProfesorId_FK",
                table: "Radi");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId_FK",
                table: "Radi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Administracija_FK",
                table: "Radi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Radi_Administracija_Administracija_FK",
                table: "Radi",
                column: "Administracija_FK",
                principalTable: "Administracija",
                principalColumn: "AdministracijaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Radi_Profesor_ProfesorId_FK",
                table: "Radi",
                column: "ProfesorId_FK",
                principalTable: "Profesor",
                principalColumn: "ProfesorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radi_Administracija_Administracija_FK",
                table: "Radi");

            migrationBuilder.DropForeignKey(
                name: "FK_Radi_Profesor_ProfesorId_FK",
                table: "Radi");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId_FK",
                table: "Radi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Administracija_FK",
                table: "Radi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Radi_Administracija_Administracija_FK",
                table: "Radi",
                column: "Administracija_FK",
                principalTable: "Administracija",
                principalColumn: "AdministracijaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radi_Profesor_ProfesorId_FK",
                table: "Radi",
                column: "ProfesorId_FK",
                principalTable: "Profesor",
                principalColumn: "ProfesorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
