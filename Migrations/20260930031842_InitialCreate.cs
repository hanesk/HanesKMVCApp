using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HanesKMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GenderIdentity = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[,]
                {
                    { 1, null, null, null, "minionb@geemail.com", "Bob", null, "Minion", null, null },
                    { 2, null, null, null, "minionk@geemail.com", "Kevin", null, "Minion", null, null },
                    { 3, null, null, null, "minions@geemail.com", "Stuart", null, "Minion", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
