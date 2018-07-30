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
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000021", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000064", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000063", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000062", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000061", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000060", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000059", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000058", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000057", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000056", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000055", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000054", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000053", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000052", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000051", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000050", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000049", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000048", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000047", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000046", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000045", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000044", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000043", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000042", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000041", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000040", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000039", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000038", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000037", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000036", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000065", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000066", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000067", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000068", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000098", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000097", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000096", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000095", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000094", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000093", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000092", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000091", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000090", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000089", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000088", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000087", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000086", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000085", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000035", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000084", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000082", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000081", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000080", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000079", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000078", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000077", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000076", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000075", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000074", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000073", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000072", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000071", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000070", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000069", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000083", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000099", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000034", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000032", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000895", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000885", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000882", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000848", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000819", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000813", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000802", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000768", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000733", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000700", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000691", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000686", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000629", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000609", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000567", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000562", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000498", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000487", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000428", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000386", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000379", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000368", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000312", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000240", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000188", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000173", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000166", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000139", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000080", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000916", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000941", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000975", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", null, "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000001", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 469, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000031", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000030", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000029", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000028", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000027", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000026", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000025", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000024", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000023", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000022", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000021", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000020", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000019", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000018", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000033", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000017", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000015", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000014", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000013", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000012", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000011", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000010", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000009", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000008", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000007", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000006", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000005", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000004", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000003", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000002", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "connected" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000016", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "Gateway_Status" },
                values: new object[] { "gw-000100", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 475, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "gateway", "warn" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000050", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000281", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000289", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000569", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000845", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000964", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000101", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000247", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000488", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000658", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000748", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000777", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000919", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000199", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000976", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000067", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000158", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000239", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000262", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000453", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000469", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000496", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000693", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000850", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000862", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000883", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000993", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000206", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000051", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000068", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000252", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000044", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000996", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000376", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000447", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000662", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000761", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000776", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000992", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000090", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000208", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000246", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000361", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000393", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000539", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000027", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000066", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000541", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000720", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000894", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000115", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000184", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000464", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000563", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000574", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000677", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000781", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000784", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000815", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000983", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000065", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000550", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000064", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000288", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000445", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000501", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000122", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000227", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000409", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000419", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000524", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000640", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000711", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000072", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000019", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000036", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000110", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000136", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000304", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000841", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000408", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000422", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000499", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000509", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000537", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000577", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000735", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000762", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000888", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000917", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000923", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000145", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000186", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000410", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000073", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000780", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000712", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000708", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000568", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000601", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000685", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000695", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000810", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000935", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000069", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000017", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000103", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000148", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000181", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000185", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000213", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000274", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000282", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000303", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000373", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000642", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000760", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000825", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000070", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000055", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000134", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000159", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000244", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000250", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000452", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000598", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000694", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000071", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000313", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000063", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000511", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000378", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000329", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000065", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000081", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000177", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000248", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000315", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000324", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000558", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000764", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000952", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000112", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000275", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000459", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000053", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000570", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000854", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000906", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000989", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000045", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000144", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000461", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000489", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000527", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000652", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000680", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000681", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000758", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000587", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000053", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000868", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000054", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000026", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000052", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000814", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000991", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000052", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000164", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000165", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000277", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000455", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000578", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000668", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000834", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000049", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000096", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000200", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000241", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000857", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000269", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000433", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000533", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000729", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000979", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000073", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000116", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000174", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000323", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000424", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000436", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000492", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000746", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000051", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000385", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000050", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000007", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000011", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000062", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000842", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000990", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000212", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000431", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000576", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000908", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000924", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000962", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000059", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000084", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000168", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000343", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000508", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000788", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000530", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000707", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000789", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000851", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000260", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000348", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000387", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000778", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000787", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000893", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000061", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000048", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000095", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000133", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000572", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000060", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000714", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000667", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000435", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000085", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000089", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000352", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000388", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000443", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000512", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000632", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000656", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000717", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000759", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000912", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000055", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000125", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000366", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000479", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000799", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000831", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000901", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000056", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000025", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000113", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000126", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000237", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000326", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000353", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000600", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000057", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000094", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000176", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000417", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000058", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000330", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000062", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000950", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000520", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000796", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000807", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000824", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000070", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000132", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000345", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000404", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000477", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000939", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000948", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000988", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000091", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000066", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000086", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000710", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000194", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000307", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000322", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000369", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000413", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000507", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000678", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000724", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000743", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000887", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000999", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000099", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000107", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000230", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000092", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000130", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000588", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000434", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000519", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000742", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000836", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000921", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000002", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000020", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000232", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000236", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000425", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000655", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000791", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000995", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000088", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000468", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000283", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000471", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000522", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000543", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000597", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000653", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000755", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000804", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000968", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000981", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000037", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000143", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000296", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000090", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000405", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000089", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000327", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000362", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000415", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000816", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000880", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000909", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000005", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000154", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000192", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000338", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000716", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000730", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000765", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000837", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000840", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000713", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000936", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000097", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000268", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000270", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000583", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000646", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000651", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000754", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000775", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000427", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000564", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000670", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000688", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000738", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000119", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000098", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000251", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000033", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000096", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000809", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000687", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000692", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000750", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000774", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000930", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000972", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000093", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000179", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000180", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000225", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000243", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000255", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000450", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000505", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000559", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000739", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000749", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000961", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000094", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000167", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000171", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000316", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000375", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000403", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000553", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000580", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000590", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000611", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000736", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000095", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000446", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000565", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000444", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000137", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000418", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000438", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000518", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000529", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000607", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000756", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000782", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000790", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000843", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000864", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000035", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000161", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000395", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000725", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000823", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000860", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000866", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000517", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000080", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000579", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000080", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000625", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000080", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000689", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000080", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000079", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000193", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000287", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000367", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000441", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000812", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000079", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000709", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000261", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000078", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000657", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000873", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000898", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000074", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000644", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000666", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000722", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000726", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000740", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000785", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000900", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000956", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000075", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000009", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000127", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000863", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000140", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000426", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000500", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000556", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000663", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000944", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000969", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000256", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000286", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000381", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000475", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000486", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000554", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000077", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000293", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000076", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000732", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000853", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000886", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000377", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000390", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000465", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000531", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000566", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000573", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000615", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000704", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000744", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000771", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000861", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000907", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000372", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000153", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000360", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000437", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000528", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000592", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000676", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000703", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000808", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000839", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000942", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000014", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000034", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000057", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000207", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000086", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000347", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000344", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000332", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000980", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000081", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000097", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000104", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000280", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000582", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000741", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000910", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000958", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000082", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000238", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000298", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000456", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000647", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000650", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000731", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000083", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000030", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000031", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000063", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000114", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000423", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000466", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000931", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000966", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000970", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000982", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000084", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000074", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000272", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000301", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000085", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000311", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000087", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000889", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000827", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000548", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000497", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000514", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000547", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000561", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000699", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000903", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000008", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000022", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000049", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000310", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000334", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000398", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000480", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000429", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000546", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000773", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000928", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000957", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000001", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000088", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000321", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000342", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000494", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000536", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000581", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000634", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000542", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000019", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000673", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000020", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000467", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000399", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000792", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000805", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000838", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000058", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000121", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000267", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000594", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000786", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000844", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000015", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000271", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000336", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000483", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000400", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000645", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000878", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000100", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000156", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000299", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000309", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000451", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000476", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000535", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000679", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000702", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000902", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000017", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000383", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000018", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000871", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000016", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000024", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000228", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000354", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000285", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000346", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000462", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000560", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000818", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000874", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000881", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000258", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000448", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000460", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000599", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000622", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000012", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000024", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000800", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000859", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000876", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000914", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000951", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000974", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000984", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000160", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000163", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000291", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000482", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000620", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000926", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000858", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000025", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-001000", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000940", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000769", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000525", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000540", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000585", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000635", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000937", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000021", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000082", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000175", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000183", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000218", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000229", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000638", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000706", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000892", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000922", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000932", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000022", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000059", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000151", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000198", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000231", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000233", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000266", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000273", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000325", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000333", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000538", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000551", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000684", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000023", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000701", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000998", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000026", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000665", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000331", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000060", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000098", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000211", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000234", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000402", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000639", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000671", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000783", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000826", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000004", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000124", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000481", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000516", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000946", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000631", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000855", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000911", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000994", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000102", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000117", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000131", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000365", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000659", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000835", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000938", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000006", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000108", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000249", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000770", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000005", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000278", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000899", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000605", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000077", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000264", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000306", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000432", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000440", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000523", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000675", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000986", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000001", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000209", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000406", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000439", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000463", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000705", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000591", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000628", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000648", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000772", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000896", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000003", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000214", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000341", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000430", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000458", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000472", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000571", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000604", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000003", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000610", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000002", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000279", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000314", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000416", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000852", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000904", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000949", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000118", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000169", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000226", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000394", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000474", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000617", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000828", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000897", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000985", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000012", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000849", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000028", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000221", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000384", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000526", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000545", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000618", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000664", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000727", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000795", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000934", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000945", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000971", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000319", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000196", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000013", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000821", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000794", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000606", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000767", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000007", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000038", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000054", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000141", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000245", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000364", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000491", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000616", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000697", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000811", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000008", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000006", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000009", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000150", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000009", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000350", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000009", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000555", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000009", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000891", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000009", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000147", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000484", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000010", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000879", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000010", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000997", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000010", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000046", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000172", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000223", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000242", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000478", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000493", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000557", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000603", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000011", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000641", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000014", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000690", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000356", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000506", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000129", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000259", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000355", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000397", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000411", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000515", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000549", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000737", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000745", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000870", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000965", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000013", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000109", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000040", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000068", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000210", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000222", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000320", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000382", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000613", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000619", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000627", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000884", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000920", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000004", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000018", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000042", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000091", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000041", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000072", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000793", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000715", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000290", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000337", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000374", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000449", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000624", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000672", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000674", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000696", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000817", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000890", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000933", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000977", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000763", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000040", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000106", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000111", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000187", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000235", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000305", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000317", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000392", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000401", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000407", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000457", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000544", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000637", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000105", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000039", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000302", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000328", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000420", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000661", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000718", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000757", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000822", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000829", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000856", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000015", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000045", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000023", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000045", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000276", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000045", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000830", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000045", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000032", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000157", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000649", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000191", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000363", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000586", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000608", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000495", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000621", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000723", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000847", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000918", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000943", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000047", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000067", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000197", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000292", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000048", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000318", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000046", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000370", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000339", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000257", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000521", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000626", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000630", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000751", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000752", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000806", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000967", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000987", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000042", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000064", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000178", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000254", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000284", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000340", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000414", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000534", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000614", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000654", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000846", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000869", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000954", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000043", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000039", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000041", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000071", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000093", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000120", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000138", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000170", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000044", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000216", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000357", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000142", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000038", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000589", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000037", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000960", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000973", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000043", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000162", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000182", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000201", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000217", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000224", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000510", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000612", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000623", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000753", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000947", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000913", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000030", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000146", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000152", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000220", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000300", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000351", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000396", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000473", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000485", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000504", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000532", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000636", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000682", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000123", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000734", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000915", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000728", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000595", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000596", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000660", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000747", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000766", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000905", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000027", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000092", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000295", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000335", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000380", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000454", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000470", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000832", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000503", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000575", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000602", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000643", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000698", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000779", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000797", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000867", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000959", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000016", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000135", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000359", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000633", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000029", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000552", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000028", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000798", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000927", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000031", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000069", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000056", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000087", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000149", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000219", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000253", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000371", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000490", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000593", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000820", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000010", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000128", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000265", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000047", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000035", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000297", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000442", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000513", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000669", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000801", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000833", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000865", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000929", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000953", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000963", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000155", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000037", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000205", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000037", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000584", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000037", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000421", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000036", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000925", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000875", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000803", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000076", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000078", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000215", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000294", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000412", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000719", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000978", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000032", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000075", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000083", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000189", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000195", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000202", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000203", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000358", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000389", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000683", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000872", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000877", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 480, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000033", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000029", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000061", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 476, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000190", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000204", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000263", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "sm-000308", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 477, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "smokedetector", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "al-000349", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000391", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000502", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 478, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000034", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "pr-000721", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 479, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "primaryalarmbell", "gw-000037", "working" });

            migrationBuilder.InsertData(
                table: "DeviceBase",
                columns: new[] { "SerialNumber", "CreatedAt", "LastHeartbeat", "LastUpdated", "Type", "GatewayId", "Status" },
                values: new object[] { "di-000955", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 7, 30, 11, 54, 30, 481, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "directionlight", "gw-000099", "working" });

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
