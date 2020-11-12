using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_Contracts_ContractId",
                table: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_ContractId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Insurances");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Insurances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_ContractId",
                table: "Insurances",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_Contracts_ContractId",
                table: "Insurances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
