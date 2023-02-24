﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleteEntity.Migrations
{
    /// <inheritdoc />
    public partial class AddedCOachId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Athletes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Athletes");
        }
    }
}
