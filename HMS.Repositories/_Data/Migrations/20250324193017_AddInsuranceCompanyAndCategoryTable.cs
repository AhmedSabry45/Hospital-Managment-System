using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.Infrastructure._Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInsuranceCompanyAndCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Wards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Wards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Wards",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Wards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "StaffCategories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "StaffCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "StaffCategories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "StaffCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCategoryId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCompanyId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "NurseShifts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NurseShifts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "NurseShifts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "NurseShifts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "NurseActivities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NurseActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "NurseActivities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "NurseActivities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "DoctorSchedules",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "DoctorSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "DoctorSchedules",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "DoctorSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "DoctorPerformances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "DoctorPerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "DoctorPerformances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "DoctorPerformances",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Beds",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Beds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Beds",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Beds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InsuranceCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceCategory_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsuranceCategory_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceCompany_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsuranceCompany_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wards_CreatedById",
                table: "Wards",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_UpdatedById",
                table: "Wards",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCategories_CreatedById",
                table: "StaffCategories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCategories_UpdatedById",
                table: "StaffCategories",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceCategoryId",
                table: "Patients",
                column: "InsuranceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceCompanyId",
                table: "Patients",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseShifts_CreatedById",
                table: "NurseShifts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NurseShifts_UpdatedById",
                table: "NurseShifts",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NurseActivities_CreatedById",
                table: "NurseActivities",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NurseActivities_UpdatedById",
                table: "NurseActivities",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedules_CreatedById",
                table: "DoctorSchedules",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedules_UpdatedById",
                table: "DoctorSchedules",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPerformances_CreatedById",
                table: "DoctorPerformances",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPerformances_UpdatedById",
                table: "DoctorPerformances",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_CreatedById",
                table: "Beds",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_UpdatedById",
                table: "Beds",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCategory_CreatedById",
                table: "InsuranceCategory",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCategory_UpdatedById",
                table: "InsuranceCategory",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_CreatedById",
                table: "InsuranceCompany",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_UpdatedById",
                table: "InsuranceCompany",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Beds_AspNetUsers_CreatedById",
                table: "Beds",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Beds_AspNetUsers_UpdatedById",
                table: "Beds",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPerformances_AspNetUsers_CreatedById",
                table: "DoctorPerformances",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPerformances_AspNetUsers_UpdatedById",
                table: "DoctorPerformances",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSchedules_AspNetUsers_CreatedById",
                table: "DoctorSchedules",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSchedules_AspNetUsers_UpdatedById",
                table: "DoctorSchedules",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseActivities_AspNetUsers_CreatedById",
                table: "NurseActivities",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseActivities_AspNetUsers_UpdatedById",
                table: "NurseActivities",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseShifts_AspNetUsers_CreatedById",
                table: "NurseShifts",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NurseShifts_AspNetUsers_UpdatedById",
                table: "NurseShifts",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_InsuranceCategory_InsuranceCategoryId",
                table: "Patients",
                column: "InsuranceCategoryId",
                principalTable: "InsuranceCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_InsuranceCompany_InsuranceCompanyId",
                table: "Patients",
                column: "InsuranceCompanyId",
                principalTable: "InsuranceCompany",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffCategories_AspNetUsers_CreatedById",
                table: "StaffCategories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffCategories_AspNetUsers_UpdatedById",
                table: "StaffCategories",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_AspNetUsers_CreatedById",
                table: "Wards",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_AspNetUsers_UpdatedById",
                table: "Wards",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beds_AspNetUsers_CreatedById",
                table: "Beds");

            migrationBuilder.DropForeignKey(
                name: "FK_Beds_AspNetUsers_UpdatedById",
                table: "Beds");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPerformances_AspNetUsers_CreatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPerformances_AspNetUsers_UpdatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSchedules_AspNetUsers_CreatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSchedules_AspNetUsers_UpdatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseActivities_AspNetUsers_CreatedById",
                table: "NurseActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseActivities_AspNetUsers_UpdatedById",
                table: "NurseActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseShifts_AspNetUsers_CreatedById",
                table: "NurseShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_NurseShifts_AspNetUsers_UpdatedById",
                table: "NurseShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_InsuranceCategory_InsuranceCategoryId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_InsuranceCompany_InsuranceCompanyId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffCategories_AspNetUsers_CreatedById",
                table: "StaffCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffCategories_AspNetUsers_UpdatedById",
                table: "StaffCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_AspNetUsers_CreatedById",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_AspNetUsers_UpdatedById",
                table: "Wards");

            migrationBuilder.DropTable(
                name: "InsuranceCategory");

            migrationBuilder.DropTable(
                name: "InsuranceCompany");

            migrationBuilder.DropIndex(
                name: "IX_Wards_CreatedById",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_UpdatedById",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_StaffCategories_CreatedById",
                table: "StaffCategories");

            migrationBuilder.DropIndex(
                name: "IX_StaffCategories_UpdatedById",
                table: "StaffCategories");

            migrationBuilder.DropIndex(
                name: "IX_Patients_InsuranceCategoryId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_InsuranceCompanyId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_NurseShifts_CreatedById",
                table: "NurseShifts");

            migrationBuilder.DropIndex(
                name: "IX_NurseShifts_UpdatedById",
                table: "NurseShifts");

            migrationBuilder.DropIndex(
                name: "IX_NurseActivities_CreatedById",
                table: "NurseActivities");

            migrationBuilder.DropIndex(
                name: "IX_NurseActivities_UpdatedById",
                table: "NurseActivities");

            migrationBuilder.DropIndex(
                name: "IX_DoctorSchedules_CreatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropIndex(
                name: "IX_DoctorSchedules_UpdatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropIndex(
                name: "IX_DoctorPerformances_CreatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropIndex(
                name: "IX_DoctorPerformances_UpdatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropIndex(
                name: "IX_Beds_CreatedById",
                table: "Beds");

            migrationBuilder.DropIndex(
                name: "IX_Beds_UpdatedById",
                table: "Beds");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "StaffCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "StaffCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "StaffCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StaffCategories");

            migrationBuilder.DropColumn(
                name: "InsuranceCategoryId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "InsuranceCompanyId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "NurseShifts");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NurseShifts");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "NurseShifts");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "NurseShifts");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "NurseActivities");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NurseActivities");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "NurseActivities");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "NurseActivities");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DoctorSchedules");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "DoctorSchedules");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "DoctorSchedules");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DoctorPerformances");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "DoctorPerformances");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "DoctorPerformances");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Beds");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Beds");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Beds");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Beds");
        }
    }
}
