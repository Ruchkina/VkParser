using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DatabaseContext.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activities",
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
                name: "personal",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "relation",
                table: "Follower");

            migrationBuilder.AddColumn<bool>(
                name: "can_access_closed",
                table: "Follower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "cityid",
                table: "Follower",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_closed",
                table: "Follower",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "occupationid",
                table: "Follower",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Follower_cityid",
                table: "Follower",
                column: "cityid");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_occupationid",
                table: "Follower",
                column: "occupationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Follower_City_cityid",
                table: "Follower",
                column: "cityid",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Follower_Occupation_occupationid",
                table: "Follower",
                column: "occupationid",
                principalTable: "Occupation",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Follower_City_cityid",
                table: "Follower");

            migrationBuilder.DropForeignKey(
                name: "FK_Follower_Occupation_occupationid",
                table: "Follower");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropIndex(
                name: "IX_Follower_cityid",
                table: "Follower");

            migrationBuilder.DropIndex(
                name: "IX_Follower_occupationid",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "can_access_closed",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "cityid",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "is_closed",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "occupationid",
                table: "Follower");

            migrationBuilder.AddColumn<string>(
                name: "activities",
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

            migrationBuilder.AddColumn<string>(
                name: "personal",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "relation",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
