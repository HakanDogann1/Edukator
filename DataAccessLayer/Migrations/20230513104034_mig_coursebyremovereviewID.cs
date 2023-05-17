using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_coursebyremovereviewID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Reviews_ReviewID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ReviewID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "Courses",
                newName: "Review");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Courses",
                newName: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ReviewID",
                table: "Courses",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Reviews_ReviewID",
                table: "Courses",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
