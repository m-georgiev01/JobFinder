using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Data.Migrations
{
    public partial class AddNewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                defaultValue: true);

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "Money", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    JobCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOffers_Employers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOffers_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOffers_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateJobOffer",
                columns: table => new
                {
                    CandidatesId = table.Column<int>(type: "int", nullable: false),
                    JobOffersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateJobOffer", x => new { x.CandidatesId, x.JobOffersId });
                    table.ForeignKey(
                        name: "FK_CandidateJobOffer_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CandidateJobOffer_JobOffers_JobOffersId",
                        column: x => x.JobOffersId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "081218dd-1be7-45e9-a153-eb73758c9f56", "324306db-ad8a-4794-ac65-889b20777b8a", "Employer", "employer" },
                    { "148e3a33-ff37-4df0-a66f-d26416e5c981", "63029976-a769-4e98-b076-7039fb5003d6", "Administrator", "administrator" },
                    { "68dc4906-58cf-4d2b-9683-bf11ea7d4afa", "7ffd74ae-b286-424e-80ed-291735648e2a", "Candidate", "candidate" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02618b16-3bfe-49ee-951e-00e47a895bd6", 0, "f1d88c64-249e-4b85-8125-b9f8d10db759", "employer@mail.com", false, "UniCredit Bulbank", true, false, null, "employer@mail.com", "employer@mail.com", "AQAAAAEAACcQAAAAEFLFTTyjU9tFQ29dRdMeE2kqwtJBsdHfUh4F2IccG/ixblw/jy8XQeE8MheCOWGONQ==", null, false, "4a6f9e88-2da6-4180-91b5-8fdb08f3c7a0", false, "employer@mail.com" },
                    { "8dc1ad43-1bbf-4034-bd43-733b4697502f", 0, "0b47038e-c96f-4cf9-b129-1e38f06305e9", "candidate@mail.com", false, "Martin Georgiev", true, false, null, "candidate@mail.com", "candidate@mail.com", "AQAAAAEAACcQAAAAEDIQXh/oqPgCsWzYn1wzIkrETuvePXHNFOgbkv7oyl+1BG874Nd3qvc+EAFwcu6+rA==", null, false, "466a35ec-8ea2-4094-94b8-6f7fd5af5002", false, "candidate@mail.com" },
                    { "da08baf8-39be-45bd-9def-7ff7ba58309d", 0, "d2ccaa9d-d145-41ed-b294-2afe4afb37fa", "admin@mail.com", false, "Admin Admin", true, false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEPxinVGTyvTTjIq/T3fBdc60HsO0DdjN0dEC/TVtELorLFdYm2KNq+WThJRxsA/OHQ==", null, false, "93e49602-d507-4d0e-b4c2-7458ddcdb228", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Retail" },
                    { 2, "Tourism" },
                    { 3, "Banking" },
                    { 4, "Development" },
                    { 5, "Real estate" }
                });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Part time" },
                    { 2, "Full time" },
                    { 3, "Freelance project" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "081218dd-1be7-45e9-a153-eb73758c9f56", "02618b16-3bfe-49ee-951e-00e47a895bd6" },
                    { "68dc4906-58cf-4d2b-9683-bf11ea7d4afa", "8dc1ad43-1bbf-4034-bd43-733b4697502f" },
                    { "148e3a33-ff37-4df0-a66f-d26416e5c981", "da08baf8-39be-45bd-9def-7ff7ba58309d" }
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "8dc1ad43-1bbf-4034-bd43-733b4697502f" });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "02618b16-3bfe-49ee-951e-00e47a895bd6" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Content", "CreatorId", "JobCategoryId", "JobTypeId", "Salary", "Title" },
                values: new object[] { 1, "<p><strong>Description:</strong></p>\r\n\r\n<p>As an on-staff Consultant with a core focus on data analysis for client operational reviews and analysis of business issues, you will have the opportunity to work on client projects side by side with experienced project team members who have direct industry experience.</p>\r\n\r\n<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n	<li>Gather and analyze data. Document your findings and make recommendations based upon your analysis.</li>\r\n	<li>Present your findings through reporting and/or presentations.</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n	<li>3-5 years of experience working in a banking or financial service industry</li>\r\n	<li>1-2 Years of data analysis experience</li>\r\n	<li>Superior Excel skills</li>\r\n	<li>Excellent verbal and written communication skills</li>\r\n</ul>", 1, 3, 2, 1700m, "Analytical Banking Consultant" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Content", "CreatorId", "JobCategoryId", "JobTypeId", "Salary", "Title" },
                values: new object[] { 2, "<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n	<li>Design, develop and unit test solutions of any size or complexity</li>\r\n	<li>Produce clean and high-quality code</li>\r\n	<li>Diagnose defects and provide effective solutions</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n	<li>A bachelor&#39;s degree and 3+ years of professional experience in Java / Kotlin</li>\r\n	<li>Profile focused on backend development</li>\r\n	<li>Experience in container-orchestration platforms such as Kubernetes / Openshift for large scale deployment of micro services is considered as an advantage</li>\r\n	<li>Excellent verbal and written communication skills</li>\r\n	<li>Advanced English</li>\r\n</ul>", 1, 4, 2, null, "Java Backend Developer" });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Content", "CreatorId", "JobCategoryId", "JobTypeId", "Salary", "Title" },
                values: new object[] { 3, "<p><strong>Description:</strong></p>\r\n\r\n<p>Provides customers excellent telephone service to assure the retention and growth of clients&rsquo; portfolio ensuring that customers receive the best service possible.</p>\r\n\r\n<p>Duration: 8 weeks</p>\r\n\r\n<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n	<li>Analyzes client needs of service and claims, evaluates the different alternatives to satisfy them, and makes decisions to resolve them immediately</li>\r\n	<li>Promotes cross sales of financial products and services</li>\r\n	<li>Provide information regarding products and services, such as loans, credit cards, balance inquires, and other</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n	<li>Excellent customer service skills, including telephone skills and telephone etiquette</li>\r\n	<li>Detail oriented with analytical skills</li>\r\n	<li>Excellent oral and written communication skills in English and Spanish</li>\r\n</ul>", 1, 3, 1, null, "Telephone Banking Consultant" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateJobOffer_JobOffersId",
                table: "CandidateJobOffer",
                column: "JobOffersId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_UserId",
                table: "Candidates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_UserId",
                table: "Employers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_CreatorId",
                table: "JobOffers",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_JobCategoryId",
                table: "JobOffers",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_JobTypeId",
                table: "JobOffers",
                column: "JobTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateJobOffer");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "JobOffers");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "081218dd-1be7-45e9-a153-eb73758c9f56", "02618b16-3bfe-49ee-951e-00e47a895bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68dc4906-58cf-4d2b-9683-bf11ea7d4afa", "8dc1ad43-1bbf-4034-bd43-733b4697502f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "148e3a33-ff37-4df0-a66f-d26416e5c981", "da08baf8-39be-45bd-9def-7ff7ba58309d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081218dd-1be7-45e9-a153-eb73758c9f56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "148e3a33-ff37-4df0-a66f-d26416e5c981");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68dc4906-58cf-4d2b-9683-bf11ea7d4afa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dc1ad43-1bbf-4034-bd43-733b4697502f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da08baf8-39be-45bd-9def-7ff7ba58309d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02618b16-3bfe-49ee-951e-00e47a895bd6");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");
        }
    }
}
