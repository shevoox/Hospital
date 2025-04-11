using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Img", "Name", "Specialization" },
                values: new object[] { "doctor1.jpg", "Dr. Sarah Johnson", "Cardiologist" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Img", "Name", "Specialization" },
                values: new object[] { "doctor2.jpg", "Dr. David Brown", "Neurologist" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 7, "doctor3.jpg", "Dr. Lisa Anderson", "Pediatrician" },
                    { 8, "doctor4.jpg", "Dr. Mark Taylor", "Dermatologist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Img", "Name", "Specialization" },
                values: new object[] { "doctor5.jpg", "Dr. Rachel Anderson", "Orthopedic" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Img", "Name", "Specialization" },
                values: new object[] { "doctor6.jpg", "Dr. James Thompson", "Psychiatrist" });
        }
    }
}
