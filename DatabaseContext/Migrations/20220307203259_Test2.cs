using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "deactivated",
                table: "Follower",
                newName: "personal");

            migrationBuilder.AddColumn<string>(
                name: "activities",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bdate",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "education",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "relation",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sex",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activities",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "bdate",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "education",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "occupation",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "relation",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "sex",
                table: "Follower");

            migrationBuilder.RenameColumn(
                name: "personal",
                table: "Follower",
                newName: "deactivated");
        }
    }
}
