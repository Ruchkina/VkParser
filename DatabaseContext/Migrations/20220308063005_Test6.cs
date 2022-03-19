using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DatabaseContext.Migrations
{
    public partial class Test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "Follower",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "bdate",
                table: "Follower",
                newName: "Bdate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Follower",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Follower",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Follower",
                newName: "Home_town");

            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "City",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Follower",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Military",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personal_life_main",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personal_people_main",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personal_political",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personal_religion",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Relation",
                table: "Follower",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activities",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Military",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Personal_life_main",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Personal_people_main",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Personal_political",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Personal_religion",
                table: "Follower");

            migrationBuilder.DropColumn(
                name: "Relation",
                table: "Follower");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Follower",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "Bdate",
                table: "Follower",
                newName: "bdate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Follower",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Follower",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Home_town",
                table: "Follower",
                newName: "first_name");

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
                    id_city = table.Column<int>(type: "integer", nullable: false),
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
    }
}
