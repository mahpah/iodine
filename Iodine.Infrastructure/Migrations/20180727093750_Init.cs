using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iodine.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceBase",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false),
                    LastHeartbeat = table.Column<DateTimeOffset>(nullable: false),
                    GatewayId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DirectionLight_Status = table.Column<string>(nullable: true),
                    PrimaryAlarmBell_Status = table.Column<string>(nullable: true),
                    SmokeDetector_Status = table.Column<string>(nullable: true),
                    Station_Status = table.Column<string>(nullable: true),
                    StationType = table.Column<string>(nullable: true),
                    Gateway_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceBase", x => x.SerialNumber);
                    table.ForeignKey(
                        name: "FK_DeviceBase_DeviceBase_GatewayId",
                        column: x => x.GatewayId,
                        principalTable: "DeviceBase",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000017", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000065", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000064", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000063", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000062", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000061", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000060", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000059", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000058", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000057", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000056", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000055", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000054", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000053", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000066", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000052", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000050", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000049", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000048", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000047", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000046", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000045", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000044", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000043", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000042", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000041", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000040", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000039", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000038", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000051", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000067", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000068", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000069", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000098", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000097", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000096", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000095", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000094", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000093", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000092", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000091", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000090", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000089", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000088", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000087", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000086", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000085", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000084", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000083", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000082", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000081", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000080", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000079", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000078", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000077", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000076", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000075", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000074", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000073", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000072", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000071", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000070", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000037", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000099", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000036", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000034", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000943", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000875", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000842", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000778", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000738", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000697", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000695", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000686", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000673", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000637", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000628", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000609", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000600", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000001", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 419, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000571", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000551", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000510", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000487", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000464", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000404", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000301", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000296", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000284", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000243", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000211", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000203", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000174", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000102", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000565", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000002", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000003", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000004", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000033", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000032", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000031", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000030", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000029", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000028", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000027", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000026", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000025", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000024", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000023", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000022", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000021", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000020", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000019", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000018", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000017", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000016", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000015", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000014", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000013", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000012", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000011", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000010", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000009", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000008", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000007", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000006", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000005", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000035", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 424, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000100", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000069", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000498", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000613", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000627", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000636", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000723", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000763", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000817", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000946", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000160", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000161", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000177", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000195", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000452", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000293", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000473", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000486", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000617", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000840", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000933", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000074", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000124", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000181", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000235", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000269", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000397", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000494", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000308", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000069" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000681", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000435", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000409", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000829", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000907", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000988", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000071", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000170", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000360", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000481", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000491", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000591", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000599", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000601", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000774", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000413", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000910", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000350", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000561", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000572", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000592", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000674", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000755", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000802", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000869", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000067" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000033", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000116", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000310", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000365", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000068" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000915", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000699", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000707", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000714", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000998", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000111", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000188", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000421", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000509", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000531", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000569", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000608", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000655", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000664", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000720", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000747", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000936", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000767", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000304", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000548", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000658", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000678", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000939", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000964", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000075" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000264", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000347", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000460", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000507", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000564", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000570", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000999", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000074" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000784", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000733", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000679", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000756", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000851", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000952", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000955", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000068", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000696", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000071" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000838", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000071" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000945", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000085", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000208", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000214", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000555", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000578", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000616", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000657", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000703", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000730", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000734", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000896", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000072" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000038", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000218", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000245", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000309", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000412", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000436", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000445", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000533", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000683", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000524", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000222", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000196", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000626", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000824", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000849", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000940", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000968", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000216", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000295", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000307", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000381", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000448", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000451", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000508", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000596", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000528", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000014", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000204", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000346", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000426", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000579", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000847", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000987", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000057" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000019", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000056", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000227", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000348", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000399", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000974", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000056" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000557", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000492", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000276", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000067", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000117", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000291", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000328", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000390", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000517", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000537", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000593", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000721", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000865", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000105", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000172", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000371", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000810", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000884", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000913", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000950", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000972", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000053" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000311", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000054" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000372", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000496", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000788", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000054" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000803", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000055", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000059", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000063", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000134", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000638", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000624", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000722", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000035", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000568", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000623", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000944", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000066", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000313", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000320", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000382", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000560", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000595", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000642", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000670", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000731", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000489", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000768", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000895", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000996", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000027", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000119", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000232", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000321", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000405", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000538", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000663", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000809", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000858", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000133", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000783", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000063" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000430", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000282", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000088", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000112", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000113", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000126", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000248", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000254", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000462", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000586", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000648", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000059" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000084", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000118", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000298", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000483", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000495", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000647", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000765", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000770", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000060" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000029", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000044", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000099", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000137", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000352", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000383", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000680", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000715", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000771", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000976", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000061" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000086", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000062" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000928", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000058" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000031", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000690", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000814", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000899", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000004", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000009", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000021", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000042", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000104", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000157", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000385", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000418", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000419", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000466", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000532", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000898", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000879", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000953", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000980", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000047", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000340", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000446", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000607", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000929", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000935", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000937", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000092" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000028", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000229", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000274", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000901", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000319", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000762", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000661", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000922", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000020", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000193", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000366", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000406", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000743", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000981", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000088" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000045", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000048", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000098", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000220", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000258", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000735", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000432", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000444", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000653", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000757", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000794", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000845", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000888", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000925", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000962", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000075", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000121", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000536", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000552", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000090" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000442", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000329", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000581", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000746", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000629", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000643", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000649", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000700", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000801", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000848", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000241", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000384", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000414", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000428", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000523", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000606", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000604", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000631", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000054", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000098" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000125", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000098" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000165", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000098" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000515", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000098" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000114", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000142", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000175", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000246", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000323", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000470", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000575", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000652", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000740", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000583", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000574", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000302", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000759", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000786", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000830", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000877", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000090", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000368", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000370", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000665", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000906", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000984", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000094" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000005", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000013", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000036", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000281", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000283", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000455", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000775", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000885", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000916", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000932", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000032", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000034", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000129", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000178", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000179", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000184", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000286", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000912", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000816", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000761", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000710", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000577", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000676", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000782", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000796", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000841", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000861", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000016", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000182", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000223", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000265", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000294", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000479", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000546", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000480", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000787", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000977", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000983", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000089", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000212", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000240", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000322", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000351", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000542", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000705", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000859", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000864", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000612", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000484", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000341", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000259", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000868", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000062", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000176", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000192", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000207", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000367", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000443", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000584", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000692", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000745", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000844", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000919", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000941", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000025", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000199", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000317", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000407", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000415", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000449", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000499", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000553", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000956", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000006", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000046", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000095", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000127", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000250", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000079" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000880", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000708", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000978", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000081" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000162", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000082" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000691", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000777", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000821", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000923", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000975", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000300", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000520", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000541", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000582", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000610", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000625", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000633", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000615", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000672", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000779", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000825", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000843", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000934", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000094", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000103", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000135", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000169", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000292", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000550", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000597", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000656", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000675", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000086" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000587", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000500", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000376", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000567", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000082" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000819", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000082" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000837", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000082" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000100", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000234", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000395", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000465", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000511", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000639", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000713", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000742", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000949", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000961", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000053", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000083", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000392", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000439", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000566", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000588", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000701", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000704", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000820", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000846", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000084" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000022", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000335", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000361", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000363", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000060", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000082" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000854", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000099" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000620", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000540", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000314", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000660", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000744", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000835", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000836", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000839", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000951", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000079", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000159", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000249", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000256", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000393", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000305", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000497", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000671", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000706", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000724", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000754", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000881", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000942", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000050", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000146", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000316", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000362", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000563", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000727", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000646", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000018" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000789", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000273", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000251", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000832", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000850", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000857", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000891", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000993", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000061", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000139", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000206", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000247", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000280", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000353", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000355", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000267", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000400", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000458", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000469", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000549", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000693", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000886", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000900", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000902", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000197", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000016" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000410", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000016" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000719", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000016" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000741", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000016" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000168", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000017" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000425", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000903", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000948", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000019" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000123", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000813", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000904", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000979", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000994", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-001000", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000143", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000288", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000343", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000402", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000526", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000764", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000878", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000781", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000893", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000024" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000200", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000326", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000482", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000025" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000503", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000237", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000257", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000318", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000354", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000391", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000611", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000685", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000702", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000051", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000732", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000726", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000427", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000209", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000244", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000262", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000266", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000379", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000501", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000689", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000709", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000920", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000947", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000959", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000018", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000303", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000559", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000711", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000712", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000799", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000863", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000007", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000490", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000522", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000614", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000651", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000828", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000065", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000152", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000378", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000806", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000640", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000453", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000375", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000556", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000698", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000874", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000887", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000131", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000140", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000147", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000263", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000576", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000603", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000718", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000827", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000454", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000917", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000023", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000049", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000122", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000270", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000535", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000659", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000852", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000136", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000331", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000364", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000394", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000461", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000965", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000198", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000187", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000004" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000973", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000373", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000386", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000668", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000805", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000982", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000001" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000164", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000219", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000225", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000345", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000420", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000440", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000504", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000529", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000619", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000992", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000002" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000128", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000150", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000151", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000217", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000278", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000342", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000471", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000512", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000547", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000598", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000760", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000772", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000506", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000716", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000521", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000776", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000115", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000332", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000450", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000534", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000026", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000141", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000190", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000268", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000338", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000447", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000544", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000684", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000076", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000717", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000826", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000894", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000960", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000030", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000064", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000073", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000081", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000087", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000093", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000210", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000272", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000285", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000793", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000013" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000039", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000012" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000594", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000585", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000954", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000052", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000149", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000167", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000213", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000966", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000971", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000008" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000070", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000009" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000411", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000009" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000554", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000009" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000867", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000009" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000002", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000043", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000144", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000215", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000401", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000423", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000669", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000890", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000918", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000927", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000080", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000120", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000156", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000158", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000530", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000558", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000539", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000007" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000545", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000807", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000889", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000605", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000860", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000892", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000914", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000958", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000037", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000058", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000403", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000525", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000573", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000758", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000790", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000602", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000792", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000092", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000096", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000109", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000132", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000155", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000201", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000253", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000429", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000475", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000634", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000650", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000748", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000873", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000749", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000543", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000324", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000622", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000752", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000798", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000909", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000221", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000231", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000261", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000315", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000325", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000562", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000590", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000635", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000488", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000641", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000985", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000991", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000299", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000040" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000396", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000040" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000800", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000040" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000897", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000040" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000072", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000173", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000191", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000224", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000236", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000239", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000041" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000739", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000931", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000108", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000202", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000424", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000048" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000505", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000048" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000580", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000048" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000011", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000015", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000082", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000242", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000359", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000417", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000474", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000750", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000862", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000183", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000048" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000924", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000049" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000279", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000306", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000441", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000468", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000513", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000725", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000728", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000737", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000773", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000130", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000356", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000516", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000051" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000008", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000154", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000048" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000797", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000047" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000472", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000047" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000812", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000853", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000856", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000870", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000876", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000957", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000431", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000476", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000682", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000753", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000780", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000872", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000930", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000045" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000001", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000091", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000106", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000205", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000333", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000339", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000358", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000662", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000729", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000804", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000911", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000040", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000047" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000374", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000047" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000377", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000047" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000357", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000349", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000290", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000289", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000389", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000456", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000457", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000477", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000502", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000630", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000644", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000667", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000811", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000057", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000459", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000808", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000153", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000834", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000908", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000989", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000163", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000171", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000186", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000228", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000312", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000327", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000334", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000433", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000618", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000621", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000871", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000107", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000010", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000694", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000963", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000148", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000252", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000277", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000398", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000416", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000485", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000632", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000769", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000815", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000833", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000027" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000101", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000233", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000344", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000434", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000478", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000677", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000866", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000882", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000905", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000986", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000990", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000028" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000003", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000189", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000260", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000287", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000589", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000029" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000666", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000818", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000736", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000185", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000751", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000791", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000926", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000938", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000012", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000138", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000180", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000337", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000388", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000408", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000437", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000493", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000687", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000823", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000036" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000230", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000275", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000336", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000467", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000514", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000518", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000654", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000822", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000855", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000024", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000078", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000255", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000226", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000037" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000527", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000438", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000422", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000194", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000271", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000297", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000369", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000387", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000463", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000645", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000688", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000766", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000785", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000795", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000831", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000883", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 429, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000969", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000995", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000077", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000097", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000166", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000330", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000519", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 428, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000967", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "di-000970", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000997", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000041", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 425, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000110", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000238", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "pr-000380", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 427, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000035" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "al-000145", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 426, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId" },
                values: new object[] { "sm-000921", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 27, 16, 37, 50, 430, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099" });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceBase_GatewayId",
                table: "DeviceBase",
                column: "GatewayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceBase");
        }
    }
}
