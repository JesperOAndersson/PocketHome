using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PocketHome.Core.Migrations
{
    public partial class AddFksAndKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Events_EventId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_Events_EventId",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Rooms_RoomId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Sections_Section1Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Scenes_Rooms_RoomId",
                table: "Scenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Triggers_Events_EventId",
                table: "Triggers");

            migrationBuilder.DropIndex(
                name: "IX_Triggers_EventId",
                table: "Triggers");

            migrationBuilder.DropIndex(
                name: "IX_Scenes_RoomId",
                table: "Scenes");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Section1Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Devices_RoomId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Conditions_EventId",
                table: "Conditions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_EventId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Triggers");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Section1Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Actions");

            migrationBuilder.AddColumn<int>(
                name: "Trigger",
                table: "Triggers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Scene",
                table: "Scenes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Room",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Device",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConditionElement",
                table: "Conditions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeraAction",
                table: "Actions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Triggers_Trigger",
                table: "Triggers",
                column: "Trigger");

            migrationBuilder.CreateIndex(
                name: "IX_Scenes_Scene",
                table: "Scenes",
                column: "Scene");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Room",
                table: "Rooms",
                column: "Room");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Section",
                table: "Rooms",
                column: "Section");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_Device",
                table: "Devices",
                column: "Device");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_ConditionElement",
                table: "Conditions",
                column: "ConditionElement");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_VeraAction",
                table: "Actions",
                column: "VeraAction");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Events_VeraAction",
                table: "Actions",
                column: "VeraAction",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditions_Events_ConditionElement",
                table: "Conditions",
                column: "ConditionElement",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Rooms_Device",
                table: "Devices",
                column: "Device",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Sections_Room",
                table: "Rooms",
                column: "Room",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Sections_Section",
                table: "Rooms",
                column: "Section",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenes_Rooms_Scene",
                table: "Scenes",
                column: "Scene",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Triggers_Events_Trigger",
                table: "Triggers",
                column: "Trigger",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Events_VeraAction",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_Events_ConditionElement",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Rooms_Device",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Sections_Room",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Sections_Section",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Scenes_Rooms_Scene",
                table: "Scenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Triggers_Events_Trigger",
                table: "Triggers");

            migrationBuilder.DropIndex(
                name: "IX_Triggers_Trigger",
                table: "Triggers");

            migrationBuilder.DropIndex(
                name: "IX_Scenes_Scene",
                table: "Scenes");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Room",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Section",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Devices_Device",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Conditions_ConditionElement",
                table: "Conditions");

            migrationBuilder.DropIndex(
                name: "IX_Actions_VeraAction",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "Trigger",
                table: "Triggers");

            migrationBuilder.DropColumn(
                name: "Scene",
                table: "Scenes");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Device",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "ConditionElement",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "VeraAction",
                table: "Actions");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Triggers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Scenes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Section1Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Actions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Triggers_EventId",
                table: "Triggers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Scenes_RoomId",
                table: "Scenes",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Section1Id",
                table: "Rooms",
                column: "Section1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RoomId",
                table: "Devices",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_EventId",
                table: "Conditions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_EventId",
                table: "Actions",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Events_EventId",
                table: "Actions",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditions_Events_EventId",
                table: "Conditions",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Rooms_RoomId",
                table: "Devices",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Sections_Section1Id",
                table: "Rooms",
                column: "Section1Id",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenes_Rooms_RoomId",
                table: "Scenes",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Triggers_Events_EventId",
                table: "Triggers",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
