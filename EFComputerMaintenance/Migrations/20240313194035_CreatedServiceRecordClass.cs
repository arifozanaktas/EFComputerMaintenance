using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFComputerMaintenance.Migrations
{
    /// <inheritdoc />
    public partial class CreatedServiceRecordClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaultDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedComplationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServiceStatuses_ServiceStatusId",
                        column: x => x.ServiceStatusId,
                        principalTable: "ServiceStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_CustomerId",
                table: "ServiceRecords",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServiceStatusId",
                table: "ServiceRecords",
                column: "ServiceStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceRecords");
        }
    }
}
