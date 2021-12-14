using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plan.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChangesWorkPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameChangesWorkPlan = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CountReason = table.Column<double>(type: "float", nullable: false),
                    ReasonChanges = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangesWorkPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characteristic1Semestr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CountDisciplinesSemester = table.Column<double>(type: "float", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Curriculum = table.Column<double>(type: "float", nullable: false),
                    AcademiсGroupsBud = table.Column<double>(type: "float", nullable: false),
                    PracticalLessonBud = table.Column<double>(type: "float", nullable: false),
                    LabLessonBud = table.Column<double>(type: "float", nullable: false),
                    AcademicGroupsCon = table.Column<double>(type: "float", nullable: false),
                    PracticalLessonCon = table.Column<double>(type: "float", nullable: false),
                    LabLessonCon = table.Column<double>(type: "float", nullable: false),
                    CodeGrup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CountStudentsBud = table.Column<double>(type: "float", nullable: false),
                    CountStudentsCon = table.Column<double>(type: "float", nullable: false),
                    CountStreamsBud = table.Column<double>(type: "float", nullable: false),
                    CountStreamsCon = table.Column<double>(type: "float", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristic1Semestr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characteristic2Semestr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CountDisciplinesSemester = table.Column<double>(type: "float", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Curriculum = table.Column<double>(type: "float", nullable: false),
                    AcademiсGroupsBud = table.Column<double>(type: "float", nullable: false),
                    PracticalLessonBud = table.Column<double>(type: "float", nullable: false),
                    LabLessonBud = table.Column<double>(type: "float", nullable: false),
                    AcademicGroupsCon = table.Column<double>(type: "float", nullable: false),
                    PracticalLessonCon = table.Column<double>(type: "float", nullable: false),
                    LabLessonCon = table.Column<double>(type: "float", nullable: false),
                    CodeGrup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CountStudentsBud = table.Column<double>(type: "float", nullable: false),
                    CountStudentsCon = table.Column<double>(type: "float", nullable: false),
                    CountStreamsBud = table.Column<double>(type: "float", nullable: false),
                    CountStreamsCon = table.Column<double>(type: "float", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristic2Semestr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlSemestr1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ExamBudPl = table.Column<double>(type: "float", nullable: false),
                    ExamBudVuc = table.Column<double>(type: "float", nullable: false),
                    ExamConPl = table.Column<double>(type: "float", nullable: false),
                    ExamConVuc = table.Column<double>(type: "float", nullable: false),
                    TestBudPl = table.Column<double>(type: "float", nullable: false),
                    TestBudVuc = table.Column<double>(type: "float", nullable: false),
                    TestConPl = table.Column<double>(type: "float", nullable: false),
                    TestConVuc = table.Column<double>(type: "float", nullable: false),
                    KRBudPl = table.Column<double>(type: "float", nullable: false),
                    KRBudVuc = table.Column<double>(type: "float", nullable: false),
                    KRConPl = table.Column<double>(type: "float", nullable: false),
                    KRConVuc = table.Column<double>(type: "float", nullable: false),
                    CursRobBudPl = table.Column<double>(type: "float", nullable: false),
                    CursRobBudVuc = table.Column<double>(type: "float", nullable: false),
                    CursRobConPl = table.Column<double>(type: "float", nullable: false),
                    CursRobConVuc = table.Column<double>(type: "float", nullable: false),
                    CursProectBudPl = table.Column<double>(type: "float", nullable: false),
                    CursProectBudVuc = table.Column<double>(type: "float", nullable: false),
                    CursProectConPl = table.Column<double>(type: "float", nullable: false),
                    CursProectConVuc = table.Column<double>(type: "float", nullable: false),
                    RGRBudPl = table.Column<double>(type: "float", nullable: false),
                    RGRBudVuc = table.Column<double>(type: "float", nullable: false),
                    RGRConPl = table.Column<double>(type: "float", nullable: false),
                    RGRConVuc = table.Column<double>(type: "float", nullable: false),
                    DKRBudPl = table.Column<double>(type: "float", nullable: false),
                    DKRBudVuc = table.Column<double>(type: "float", nullable: false),
                    DKRConPl = table.Column<double>(type: "float", nullable: false),
                    DKRConVuc = table.Column<double>(type: "float", nullable: false),
                    AbstractBudPl = table.Column<double>(type: "float", nullable: false),
                    AbstractBudVuc = table.Column<double>(type: "float", nullable: false),
                    AbstractConPl = table.Column<double>(type: "float", nullable: false),
                    AbstractConVuc = table.Column<double>(type: "float", nullable: false),
                    CosultationBudPl = table.Column<double>(type: "float", nullable: false),
                    CosultationBudVuc = table.Column<double>(type: "float", nullable: false),
                    CosultationConPl = table.Column<double>(type: "float", nullable: false),
                    CosultationConVuc = table.Column<double>(type: "float", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlSemestr1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlSemestr2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ExamBudPl = table.Column<double>(type: "float", nullable: false),
                    ExamBudVuc = table.Column<double>(type: "float", nullable: false),
                    ExamConPl = table.Column<double>(type: "float", nullable: false),
                    ExamConVuc = table.Column<double>(type: "float", nullable: false),
                    TestBudPl = table.Column<double>(type: "float", nullable: false),
                    TestBudVuc = table.Column<double>(type: "float", nullable: false),
                    TestConPl = table.Column<double>(type: "float", nullable: false),
                    TestConVuc = table.Column<double>(type: "float", nullable: false),
                    KRBudPl = table.Column<double>(type: "float", nullable: false),
                    KRBudVuc = table.Column<double>(type: "float", nullable: false),
                    KRConPl = table.Column<double>(type: "float", nullable: false),
                    KRConVuc = table.Column<double>(type: "float", nullable: false),
                    CursRobBudPl = table.Column<double>(type: "float", nullable: false),
                    CursRobBudVuc = table.Column<double>(type: "float", nullable: false),
                    CursRobConPl = table.Column<double>(type: "float", nullable: false),
                    CursRobConVuc = table.Column<double>(type: "float", nullable: false),
                    CursProectBudPl = table.Column<double>(type: "float", nullable: false),
                    CursProectBudVuc = table.Column<double>(type: "float", nullable: false),
                    CursProectConPl = table.Column<double>(type: "float", nullable: false),
                    CursProectConVuc = table.Column<double>(type: "float", nullable: false),
                    RGRBudPl = table.Column<double>(type: "float", nullable: false),
                    RGRBudVuc = table.Column<double>(type: "float", nullable: false),
                    RGRConPl = table.Column<double>(type: "float", nullable: false),
                    RGRConVuc = table.Column<double>(type: "float", nullable: false),
                    DKRBudPl = table.Column<double>(type: "float", nullable: false),
                    DKRBudVuc = table.Column<double>(type: "float", nullable: false),
                    DKRConPl = table.Column<double>(type: "float", nullable: false),
                    DKRConVuc = table.Column<double>(type: "float", nullable: false),
                    AbstractBudPl = table.Column<double>(type: "float", nullable: false),
                    AbstractBudVuc = table.Column<double>(type: "float", nullable: false),
                    AbstractConPl = table.Column<double>(type: "float", nullable: false),
                    AbstractConVuc = table.Column<double>(type: "float", nullable: false),
                    CosultationBudPl = table.Column<double>(type: "float", nullable: false),
                    CosultationBudVuc = table.Column<double>(type: "float", nullable: false),
                    CosultationConPl = table.Column<double>(type: "float", nullable: false),
                    CosultationConVuc = table.Column<double>(type: "float", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlSemestr2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEducationalActivities = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LectureClassesNameSums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameColum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureClassesNameSums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LectureClassesSemestr1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LectureBudPl = table.Column<int>(type: "int", nullable: false),
                    LectureBudVuc = table.Column<int>(type: "int", nullable: false),
                    LectureConPl = table.Column<int>(type: "int", nullable: false),
                    LectureConVuc = table.Column<int>(type: "int", nullable: false),
                    PractBudPl = table.Column<int>(type: "int", nullable: false),
                    PractBudVuc = table.Column<int>(type: "int", nullable: false),
                    PractConPl = table.Column<int>(type: "int", nullable: false),
                    PractConVuc = table.Column<int>(type: "int", nullable: false),
                    LabBudPl = table.Column<int>(type: "int", nullable: false),
                    LabBudVuc = table.Column<int>(type: "int", nullable: false),
                    LabConPl = table.Column<int>(type: "int", nullable: false),
                    LabConVuc = table.Column<int>(type: "int", nullable: false),
                    IndBudPl = table.Column<int>(type: "int", nullable: false),
                    IndBudVuc = table.Column<int>(type: "int", nullable: false),
                    IndConPl = table.Column<int>(type: "int", nullable: false),
                    IndConVuc = table.Column<int>(type: "int", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureClassesSemestr1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LectureClassesSemestr2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAcademiDisciplines = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LectureBudPl = table.Column<int>(type: "int", nullable: false),
                    LectureBudVuc = table.Column<int>(type: "int", nullable: false),
                    LectureConPl = table.Column<int>(type: "int", nullable: false),
                    LectureConVuc = table.Column<int>(type: "int", nullable: false),
                    PractBudPl = table.Column<int>(type: "int", nullable: false),
                    PractBudVuc = table.Column<int>(type: "int", nullable: false),
                    PractConPl = table.Column<int>(type: "int", nullable: false),
                    PractConVuc = table.Column<int>(type: "int", nullable: false),
                    LabBudPl = table.Column<int>(type: "int", nullable: false),
                    LabBudVuc = table.Column<int>(type: "int", nullable: false),
                    LabConPl = table.Column<int>(type: "int", nullable: false),
                    LabConVuc = table.Column<int>(type: "int", nullable: false),
                    IndBudPl = table.Column<int>(type: "int", nullable: false),
                    IndBudVuc = table.Column<int>(type: "int", nullable: false),
                    IndConPl = table.Column<int>(type: "int", nullable: false),
                    IndConVuc = table.Column<int>(type: "int", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureClassesSemestr2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MethodicalWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMethodicalWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodicalWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NameSubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameSubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationalWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOrganizationalWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherTypesWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOtherTypesWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Course = table.Column<double>(type: "float", nullable: false),
                    CodeGrup = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CountStudentsBud = table.Column<double>(type: "float", nullable: false),
                    CountStudentsCon = table.Column<double>(type: "float", nullable: false),
                    HoursBudPl = table.Column<double>(type: "float", nullable: false),
                    HoursBudVuc = table.Column<double>(type: "float", nullable: false),
                    HoursConPl = table.Column<double>(type: "float", nullable: false),
                    HoursConVuc = table.Column<double>(type: "float", nullable: false),
                    ColumId = table.Column<int>(type: "int", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTypesWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherTypesWorkSemestr2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOtherTypesWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Course = table.Column<double>(type: "float", nullable: false),
                    CodeGrup = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CountStudentsBud = table.Column<double>(type: "float", nullable: false),
                    CountStudentsCon = table.Column<double>(type: "float", nullable: false),
                    HoursBudPl = table.Column<double>(type: "float", nullable: false),
                    HoursBudVuc = table.Column<double>(type: "float", nullable: false),
                    HoursConPl = table.Column<double>(type: "float", nullable: false),
                    HoursConVuc = table.Column<double>(type: "float", nullable: false),
                    ColumId = table.Column<int>(type: "int", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTypesWorkSemestr2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScientificWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameScientificWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DateSuccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScientificWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DbUserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkloadSum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameWorkloadSum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeachingBudPl = table.Column<double>(type: "float", nullable: false),
                    TeachingBudVuc = table.Column<double>(type: "float", nullable: false),
                    TeachingConPl = table.Column<double>(type: "float", nullable: false),
                    TeachingConVuc = table.Column<double>(type: "float", nullable: false),
                    OtherBudPl = table.Column<double>(type: "float", nullable: false),
                    OtherBudVuc = table.Column<double>(type: "float", nullable: false),
                    OtherConPl = table.Column<double>(type: "float", nullable: false),
                    OtherConVuc = table.Column<double>(type: "float", nullable: false),
                    AllBudPl = table.Column<double>(type: "float", nullable: false),
                    AllBudVuc = table.Column<double>(type: "float", nullable: false),
                    AllConPl = table.Column<double>(type: "float", nullable: false),
                    AllConVuc = table.Column<double>(type: "float", nullable: false),
                    EmailTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkloadSum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChangesWorkPlan");

            migrationBuilder.DropTable(
                name: "Characteristic1Semestr");

            migrationBuilder.DropTable(
                name: "Characteristic2Semestr");

            migrationBuilder.DropTable(
                name: "ControlSemestr1");

            migrationBuilder.DropTable(
                name: "ControlSemestr2");

            migrationBuilder.DropTable(
                name: "EducationalActivities");

            migrationBuilder.DropTable(
                name: "LectureClassesNameSums");

            migrationBuilder.DropTable(
                name: "LectureClassesSemestr1");

            migrationBuilder.DropTable(
                name: "LectureClassesSemestr2");

            migrationBuilder.DropTable(
                name: "MethodicalWork");

            migrationBuilder.DropTable(
                name: "NameSubject");

            migrationBuilder.DropTable(
                name: "OrganizationalWork");

            migrationBuilder.DropTable(
                name: "OtherTypesWork");

            migrationBuilder.DropTable(
                name: "OtherTypesWorkSemestr2");

            migrationBuilder.DropTable(
                name: "ScientificWork");

            migrationBuilder.DropTable(
                name: "UserNames");

            migrationBuilder.DropTable(
                name: "WorkloadSum");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
