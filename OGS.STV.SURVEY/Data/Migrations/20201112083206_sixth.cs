using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ContractInsurances_ContractId",
                table: "ContractInsurances",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances");

            migrationBuilder.DropIndex(
                name: "IX_ContractInsurances_ContractId",
                table: "ContractInsurances");
        }
    }
}
