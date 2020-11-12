using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Insurances",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SurveyUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCNO = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyUser_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyUserId = table.Column<int>(nullable: true),
                    MailSendStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_SurveyUser_SurveyUserId",
                        column: x => x.SurveyUserId,
                        principalTable: "SurveyUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_ContractId",
                table: "Insurances",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SurveyUserId",
                table: "Contracts",
                column: "SurveyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUser_CityId",
                table: "SurveyUser",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_Contracts_ContractId",
                table: "Insurances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_Contracts_ContractId",
                table: "Insurances");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "SurveyUser");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_ContractId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Insurances");
        }
    }
}
