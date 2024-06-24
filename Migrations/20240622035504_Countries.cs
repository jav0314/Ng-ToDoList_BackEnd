using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Countries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Cod",
                table: "Countries",
                newName: "COD");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "COD",
                table: "Countries",
                newName: "Cod");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Countries",
                newName: "Id");
        }
    }
}
