using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeCreatorApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bio",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    photo_url = table.Column<string>(nullable: true),
                    biography = table.Column<string>(maxLength: 400, nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "education",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    institution = table.Column<string>(maxLength: 125, nullable: false),
                    degree = table.Column<string>(maxLength: 200, nullable: false),
                    grade_point_average = table.Column<float>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill_category",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill_level",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill_level", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    first_name = table.Column<string>(nullable: false),
                    middle_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "education_extra",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(maxLength: 250, nullable: false),
                    education_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education_extra", x => x.id);
                    table.ForeignKey(
                        name: "FK_education_extra_education_education_id",
                        column: x => x.education_id,
                        principalTable: "education",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    employer = table.Column<string>(maxLength: 100, nullable: false),
                    role = table.Column<string>(maxLength: 100, nullable: false),
                    location = table.Column<string>(maxLength: 100, nullable: true),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job", x => x.id);
                    table.ForeignKey(
                        name: "FK_job_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    skill_category_id = table.Column<Guid>(nullable: false),
                    skill_level_id = table.Column<Guid>(nullable: false),
                    user_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.id);
                    table.ForeignKey(
                        name: "FK_skill_skill_category_skill_category_id",
                        column: x => x.skill_category_id,
                        principalTable: "skill_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_skill_skill_level_skill_level_id",
                        column: x => x.skill_level_id,
                        principalTable: "skill_level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_skill_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_email",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    email_address = table.Column<string>(maxLength: 320, nullable: false),
                    user_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_email", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_email_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_phone_number",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    country_code = table.Column<int>(nullable: false),
                    area_code = table.Column<int>(nullable: false),
                    phone_number = table.Column<int>(nullable: false),
                    extension = table.Column<int>(nullable: false),
                    user_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_phone_number", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_phone_number_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job_experience",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    job_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_experience", x => x.id);
                    table.ForeignKey(
                        name: "FK_job_experience_job_job_id",
                        column: x => x.job_id,
                        principalTable: "job",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job_skill",
                columns: table => new
                {
                    job_id = table.Column<Guid>(nullable: false),
                    skill_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_skill", x => new { x.job_id, x.skill_id });
                    table.ForeignKey(
                        name: "FK_job_skill_job_job_id",
                        column: x => x.job_id,
                        principalTable: "job",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_skill_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resume",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    career = table.Column<string>(nullable: false),
                    experience_in_years = table.Column<int>(nullable: false),
                    display_phone_number_id = table.Column<Guid>(nullable: false),
                    display_email_id = table.Column<Guid>(nullable: false),
                    user_id = table.Column<Guid>(nullable: false),
                    bio_id = table.Column<Guid>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resume", x => x.id);
                    table.ForeignKey(
                        name: "FK_resume_bio_bio_id",
                        column: x => x.bio_id,
                        principalTable: "bio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resume_user_email_display_email_id",
                        column: x => x.display_email_id,
                        principalTable: "user_email",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resume_user_phone_number_display_phone_number_id",
                        column: x => x.display_phone_number_id,
                        principalTable: "user_phone_number",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resume_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_education_extra_education_id",
                table: "education_extra",
                column: "education_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_user_id",
                table: "job",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_experience_job_id",
                table: "job_experience",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_skill_skill_id",
                table: "job_skill",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_resume_bio_id",
                table: "resume",
                column: "bio_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resume_display_email_id",
                table: "resume",
                column: "display_email_id");

            migrationBuilder.CreateIndex(
                name: "IX_resume_display_phone_number_id",
                table: "resume",
                column: "display_phone_number_id");

            migrationBuilder.CreateIndex(
                name: "IX_resume_user_id",
                table: "resume",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_skill_category_id",
                table: "skill",
                column: "skill_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_skill_level_id",
                table: "skill",
                column: "skill_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_user_id",
                table: "skill",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_email_user_id",
                table: "user_email",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_phone_number_user_id",
                table: "user_phone_number",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "education_extra");

            migrationBuilder.DropTable(
                name: "job_experience");

            migrationBuilder.DropTable(
                name: "job_skill");

            migrationBuilder.DropTable(
                name: "resume");

            migrationBuilder.DropTable(
                name: "education");

            migrationBuilder.DropTable(
                name: "job");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "bio");

            migrationBuilder.DropTable(
                name: "user_email");

            migrationBuilder.DropTable(
                name: "user_phone_number");

            migrationBuilder.DropTable(
                name: "skill_category");

            migrationBuilder.DropTable(
                name: "skill_level");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
