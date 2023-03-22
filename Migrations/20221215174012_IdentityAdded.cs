using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RowVehiclePoolMVC.Migrations
{
    public partial class IdentityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterfaceErrorLogging",
                columns: table => new
                {
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    ErrorCode = table.Column<int>(name: "Error Code", nullable: false),
                    ErrorMessage = table.Column<string>(name: "Error Message", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    TagNumber = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    VehYear = table.Column<decimal>(type: "numeric(4, 0)", nullable: false),
                    Make = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Model = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Color = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    VehicleType = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Status = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    OwnerBudget = table.Column<string>(unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Mileage = table.Column<decimal>(type: "numeric(6, 0)", nullable: true),
                    OutOfServiceBegin = table.Column<DateTime>(type: "datetime", nullable: true),
                    OutOfServiceEnd = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.TagNumber);
                });

            migrationBuilder.CreateTable(
                name: "VehicleAssignment",
                columns: table => new
                {
                    VehReqNo = table.Column<int>(nullable: false),
                    AssignNo = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    AssignTagNo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    AssignDepartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AssignReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Comments = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAssignment", x => new { x.VehReqNo, x.AssignNo });
                });

            migrationBuilder.CreateTable(
                name: "VehicleFunction",
                columns: table => new
                {
                    FUNC = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    FUNCTION_DESC = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFunction", x => x.FUNC);
                });

            migrationBuilder.CreateTable(
                name: "VehicleRequisition",
                columns: table => new
                {
                    VehReqNo = table.Column<int>(nullable: false),
                    VehReqDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Requestor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    VehType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Destination = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Duties = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    NoInParty = table.Column<decimal>(type: "decimal(2, 0)", nullable: false),
                    ReqDivision = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ReqSectionID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ReqBudget = table.Column<string>(unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ReqFunction = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ReqJobNo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    ReqFAP = table.Column<string>(unicode: false, fixedLength: true, maxLength: 11, nullable: false),
                    ReqComments = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ReqDepartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReqReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Userid = table.Column<string>(unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    VehReqStatus = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    NotificationDivHead = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    NotificationMan = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastChangeUserid = table.Column<string>(unicode: false, fixedLength: true, maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRequisition", x => x.VehReqNo);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAssignment",
                table: "VehicleAssignment",
                column: "VehReqNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20170815-094707",
                table: "VehicleAssignment",
                columns: new[] { "VehReqNo", "AssignNo", "Comments", "AssignTagNo", "AssignDepartDate", "AssignReturnDate" });
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
                name: "InterfaceErrorLogging");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleAssignment");

            migrationBuilder.DropTable(
                name: "VehicleFunction");

            migrationBuilder.DropTable(
                name: "VehicleRequisition");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
