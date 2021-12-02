using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisanBilgi.Data.Migrations
{
    public partial class AddEmployeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeLeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeLeaveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeLeaveAlloction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    EmployeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeLeaveTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeLeaveAlloction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeLeaveAlloction_AspNetUsers_EmployeId",
                        column: x => x.EmployeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeLeaveAlloction_EmployeLeaveType_EmployeLeaveTypeId",
                        column: x => x.EmployeLeaveTypeId,
                        principalTable: "EmployeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeLeaveRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApprovedEmployeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeLeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeLeaveRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeLeaveRequest_AspNetUsers_ApprovedEmployeId",
                        column: x => x.ApprovedEmployeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeLeaveRequest_AspNetUsers_RequestingEmployeId",
                        column: x => x.RequestingEmployeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeLeaveRequest_EmployeLeaveType_EmployeLeaveTypeId",
                        column: x => x.EmployeLeaveTypeId,
                        principalTable: "EmployeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeLeaveAlloction_EmployeId",
                table: "EmployeLeaveAlloction",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeLeaveAlloction_EmployeLeaveTypeId",
                table: "EmployeLeaveAlloction",
                column: "EmployeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeLeaveRequest_ApprovedEmployeId",
                table: "EmployeLeaveRequest",
                column: "ApprovedEmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeLeaveRequest_EmployeLeaveTypeId",
                table: "EmployeLeaveRequest",
                column: "EmployeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeLeaveRequest_RequestingEmployeId",
                table: "EmployeLeaveRequest",
                column: "RequestingEmployeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeLeaveAlloction");

            migrationBuilder.DropTable(
                name: "EmployeLeaveRequest");

            migrationBuilder.DropTable(
                name: "EmployeLeaveType");
        }
    }
}
