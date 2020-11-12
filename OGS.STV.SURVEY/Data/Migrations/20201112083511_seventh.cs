using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances");

            migrationBuilder.AlterColumn<int>(
                name: "InsuranceId",
                table: "ContractInsurances",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "ContractInsurances",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ContractInsurances_InsuranceId",
                table: "ContractInsurances",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInsurances_Insurances_InsuranceId",
                table: "ContractInsurances",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractInsurances_Insurances_InsuranceId",
                table: "ContractInsurances");

            migrationBuilder.DropIndex(
                name: "IX_ContractInsurances_InsuranceId",
                table: "ContractInsurances");

            migrationBuilder.AlterColumn<int>(
                name: "InsuranceId",
                table: "ContractInsurances",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "ContractInsurances",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInsurances_Contracts_ContractId",
                table: "ContractInsurances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
