using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFComputerMaintenance.Migrations
{
    /// <inheritdoc />
    public partial class CreatedInvoiceClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Staffs",
                newName: "IsActiveOrComplate");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "SpareParts",
                newName: "IsActiveOrComplate");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ServiceStatuses",
                newName: "IsActiveOrComplate");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ServiceRecords",
                newName: "IsActiveOrComplate");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Customers",
                newName: "IsActiveOrComplate");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRecordId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveOrComplate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_ServiceRecords_ServiceRecordId",
                        column: x => x.ServiceRecordId,
                        principalTable: "ServiceRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.RenameColumn(
                name: "IsActiveOrComplate",
                table: "Staffs",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActiveOrComplate",
                table: "SpareParts",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActiveOrComplate",
                table: "ServiceStatuses",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActiveOrComplate",
                table: "ServiceRecords",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsActiveOrComplate",
                table: "Customers",
                newName: "IsActive");
        }
    }
}
