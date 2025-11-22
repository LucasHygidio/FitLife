using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Migrations
{
    /// <inheritdoc />
    public partial class NewDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.IdUser);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutLogTable_UserId",
                table: "WorkOutLogTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitLogTable_UserId",
                table: "HabitLogTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DietLogTable_UserId",
                table: "DietLogTable",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietLogTable_UserTable_UserId",
                table: "DietLogTable",
                column: "UserId",
                principalTable: "UserTable",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitLogTable_UserTable_UserId",
                table: "HabitLogTable",
                column: "UserId",
                principalTable: "UserTable",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOutLogTable_UserTable_UserId",
                table: "WorkOutLogTable",
                column: "UserId",
                principalTable: "UserTable",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietLogTable_UserTable_UserId",
                table: "DietLogTable");

            migrationBuilder.DropForeignKey(
                name: "FK_HabitLogTable_UserTable_UserId",
                table: "HabitLogTable");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOutLogTable_UserTable_UserId",
                table: "WorkOutLogTable");

            migrationBuilder.DropTable(
                name: "UserTable");

            migrationBuilder.DropIndex(
                name: "IX_WorkOutLogTable_UserId",
                table: "WorkOutLogTable");

            migrationBuilder.DropIndex(
                name: "IX_HabitLogTable_UserId",
                table: "HabitLogTable");

            migrationBuilder.DropIndex(
                name: "IX_DietLogTable_UserId",
                table: "DietLogTable");
        }
    }
}
