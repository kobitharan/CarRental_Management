using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class _1st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NicNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerUser",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Licence = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OngoingRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUser", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NicNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Model_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_CustomerUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginHistory",
                columns: table => new
                {
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    DeviceInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistory", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_LoginHistory_CustomerUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    PhoneNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mobile1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_CustomerUser_UserId",
                        column: x => x.UserId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUsers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffAddress",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_StaffAddress_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentalCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OngoingRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoginHistoryStaff",
                columns: table => new
                {
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    DeviceInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistoryStaff", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_LoginHistoryStaff_EmployeeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "EmployeeUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImage",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImage", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_CarImage_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    FavouriteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => x.FavouriteId);
                    table.ForeignKey(
                        name: "FK_Favourite_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourite_CustomerUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalRequest",
                columns: table => new
                {
                    RentalRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OverDueDuration = table.Column<int>(type: "int", nullable: false),
                    OverDueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalRequest", x => x.RentalRequestId);
                    table.ForeignKey(
                        name: "FK_RentalRequest_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalRequest_CustomerUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerUserCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_CustomerUser_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_CustomerUser_CustomerUserCustomerId",
                        column: x => x.CustomerUserCustomerId,
                        principalTable: "CustomerUser",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Payment_RentalRequest_RentalRequestId",
                        column: x => x.RentalRequestId,
                        principalTable: "RentalRequest",
                        principalColumn: "RentalRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerId",
                table: "Address",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_BrandId",
                table: "Car",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModelId",
                table: "Car",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_CarId",
                table: "CarImage",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_EmployeeId",
                table: "EmployeeUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_CarId",
                table: "Favourite",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_CustomerId",
                table: "Favourite",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistory_CustomerId",
                table: "LoginHistory",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistoryStaff_UserId",
                table: "LoginHistoryStaff",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandId",
                table: "Model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerUserCustomerId",
                table: "Payment",
                column: "CustomerUserCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_RentalRequestId",
                table: "Payment",
                column: "RentalRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_UserId",
                table: "PhoneNumber",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRequest_CarId",
                table: "RentalRequest",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRequest_CustomerId",
                table: "RentalRequest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAddress_EmployeeId",
                table: "StaffAddress",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AdminUsers");

            migrationBuilder.DropTable(
                name: "CarImage");

            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "LoginHistory");

            migrationBuilder.DropTable(
                name: "LoginHistoryStaff");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "StaffAddress");

            migrationBuilder.DropTable(
                name: "EmployeeUsers");

            migrationBuilder.DropTable(
                name: "RentalRequest");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "CustomerUser");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
