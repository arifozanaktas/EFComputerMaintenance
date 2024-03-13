using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFComputerMaintenance.Migrations
{
    /// <inheritdoc />
    public partial class WhoDidIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ServiceStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStatuses_StaffId",
                table: "ServiceStatuses",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceStatuses_Staffs_StaffId",
                table: "ServiceStatuses",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceStatuses_Staffs_StaffId",
                table: "ServiceStatuses");

            migrationBuilder.DropIndex(
                name: "IX_ServiceStatuses_StaffId",
                table: "ServiceStatuses");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ServiceStatuses");
        }
    }
}
