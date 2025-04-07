using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace accesslayaer.Migrations
{
    /// <inheritdoc />
    public partial class itcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    Name = table.Column<string>(type: "varchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "varchar(max)", nullable: false),
                    createdby = table.Column<int>(type: "int", nullable: false),
                    createdon = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE"),
                    lastmodifiedby = table.Column<int>(type: "int", nullable: false),
                    lastmodifiedon = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GETDATE"),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "department");
        }
    }
}
