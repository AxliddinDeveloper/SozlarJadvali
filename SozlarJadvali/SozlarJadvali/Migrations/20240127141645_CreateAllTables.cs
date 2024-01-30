using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SozlarJadvali.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    YordamchiSoz = table.Column<string>(type: "TEXT", nullable: true),
                    Turkumi = table.Column<string>(type: "TEXT", nullable: true),
                    XalqaroTegi = table.Column<string>(type: "TEXT", nullable: true),
                    OzbekchaTegi = table.Column<string>(type: "TEXT", nullable: true),
                    SofvazifaDosh = table.Column<string>(type: "TEXT", nullable: true),
                    Shakli = table.Column<string>(type: "TEXT", nullable: true),
                    ManoTuri = table.Column<string>(type: "TEXT", nullable: true),
                    UslubiyXoslanishi = table.Column<string>(type: "TEXT", nullable: true),
                    SofTurkumi = table.Column<string>(type: "TEXT", nullable: true),
                    YordamchiSozVaOlinganManba = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Word");
        }
    }
}
