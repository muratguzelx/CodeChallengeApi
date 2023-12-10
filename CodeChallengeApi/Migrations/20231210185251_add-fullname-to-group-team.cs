using Microsoft.EntityFrameAdessoCore.Migrations;

#nullable disable

namespace CodeChallengeApi.Migrations
{
    public partial class addfullnametogroupteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "GroupTeams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "GroupTeams");
        }
    }
}
