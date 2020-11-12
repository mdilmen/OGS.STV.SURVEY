using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_SurveyUser_SurveyUserId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyUser_Cities_CityId",
                table: "SurveyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyUser",
                table: "SurveyUser");

            migrationBuilder.RenameTable(
                name: "SurveyUser",
                newName: "SurveyUsers");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyUser_CityId",
                table: "SurveyUsers",
                newName: "IX_SurveyUsers_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyUsers",
                table: "SurveyUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_SurveyUsers_SurveyUserId",
                table: "Contracts",
                column: "SurveyUserId",
                principalTable: "SurveyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyUsers_Cities_CityId",
                table: "SurveyUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_SurveyUsers_SurveyUserId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyUsers_Cities_CityId",
                table: "SurveyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyUsers",
                table: "SurveyUsers");

            migrationBuilder.RenameTable(
                name: "SurveyUsers",
                newName: "SurveyUser");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyUsers_CityId",
                table: "SurveyUser",
                newName: "IX_SurveyUser_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyUser",
                table: "SurveyUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_SurveyUser_SurveyUserId",
                table: "Contracts",
                column: "SurveyUserId",
                principalTable: "SurveyUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyUser_Cities_CityId",
                table: "SurveyUser",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
