using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class init2221wzvjh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Links_LinksId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonalInfo_PersonalInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CvTemplates_AspNetUsers_UserDataId",
                table: "CvTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_AspNetUsers_UserDataId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_AspNetUsers_UserDataId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_AspNetUsers_UserDataId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LinksId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonalInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CoverLetter",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LinksId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Skill",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Project",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Experience",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "CvTemplates",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalInfoId = table.Column<int>(type: "int", nullable: false),
                    CoverLetter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinksId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserData_Links_LinksId",
                        column: x => x.LinksId,
                        principalTable: "Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserData_PersonalInfo_PersonalInfoId",
                        column: x => x.PersonalInfoId,
                        principalTable: "PersonalInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserData_LinksId",
                table: "UserData",
                column: "LinksId");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_PersonalInfoId",
                table: "UserData",
                column: "PersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CvTemplates_UserData_UserDataId",
                table: "CvTemplates",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_UserData_UserDataId",
                table: "Experience",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_UserData_UserDataId",
                table: "Project",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_UserData_UserDataId",
                table: "Skill",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CvTemplates_UserData_UserDataId",
                table: "CvTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_UserData_UserDataId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_UserData_UserDataId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_UserData_UserDataId",
                table: "Skill");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.AlterColumn<string>(
                name: "UserDataId",
                table: "Skill",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserDataId",
                table: "Project",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserDataId",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserDataId",
                table: "CvTemplates",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverLetter",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LinksId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LinksId",
                table: "AspNetUsers",
                column: "LinksId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonalInfoId",
                table: "AspNetUsers",
                column: "PersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Links_LinksId",
                table: "AspNetUsers",
                column: "LinksId",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonalInfo_PersonalInfoId",
                table: "AspNetUsers",
                column: "PersonalInfoId",
                principalTable: "PersonalInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CvTemplates_AspNetUsers_UserDataId",
                table: "CvTemplates",
                column: "UserDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_AspNetUsers_UserDataId",
                table: "Experience",
                column: "UserDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_AspNetUsers_UserDataId",
                table: "Project",
                column: "UserDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_AspNetUsers_UserDataId",
                table: "Skill",
                column: "UserDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
