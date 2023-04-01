using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathnostics.Web.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FixationType",
                table: "SampleDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FixationType",
                table: "SampleDatas");
        }
    }
}
