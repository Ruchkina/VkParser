using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Follower",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Follower",
                newName: "last_name");

            migrationBuilder.AddColumn<string>(
                name: "deactivated",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Follower",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deactivated",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Follower");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Follower",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Follower",
                newName: "Gender");
        }
    }
}
