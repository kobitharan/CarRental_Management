using Car_Rental_Management_System.Areas.Admin.Models;
using Car_Rental_Management_System.Areas.Customer.Models;
using Car_Rental_Management_System.Areas.Staff.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Admin side
        public DbSet<Brand> Brand { get; set; }
        public DbSet<CarViewModels> Car { get; set; }
        public DbSet<CarImage> CarImage { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<AdminUsers> AdminUsers { get; set; }

        // Customer side
        public DbSet<Address> Address { get; set; }
        public DbSet<CustomerUser> CustomerUser { get; set; }
        public DbSet<Favourite> Favourite { get; set; }
        public DbSet<LoginHistory> LoginHistory { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<RentalRequest> RentalRequest { get; set; }

        // Staff side
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeUsers> EmployeeUsers { get; set; }
        public DbSet<StaffAddress> StaffAddress { get; set; }
        public DbSet<LoginHistoryStaff> LoginHistoryStaff { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Car - Model relationship
            modelBuilder.Entity<CarViewModels>()
                .HasOne(c => c.Model)
                .WithMany()
                .HasForeignKey(c => c.ModelId)
                .OnDelete(DeleteBehavior.Restrict);

            // Decimal precision for Car
            modelBuilder.Entity<CarViewModels>()
                .Property(c => c.PricePerDay)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CarViewModels>()
                .Property(c => c.OngoingRevenue)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CarViewModels>()
                .Property(c => c.TotalRevenue)
                .HasColumnType("decimal(18,2)");

            // Decimal precision for CustomerUser
            modelBuilder.Entity<CustomerUser>()
                .Property(c => c.OngoingRevenue)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CustomerUser>()
                .Property(c => c.TotalRevenue)
                .HasColumnType("decimal(18,2)");

            // Decimal precision for RentalRequest
            modelBuilder.Entity<RentalRequest>()
                .Property(r => r.TotalPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<RentalRequest>()
                .Property(r => r.OverDueAmount)
                .HasColumnType("decimal(18,2)");

            // FIX: Remove multiple cascade path issue
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.CustomerUser)
                .WithMany()
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict); // No cascade

            //modelBuilder.Entity<Payment>()
            //    .HasOne(p => p.RentalRequest)
            //    .WithMany()
            //    .HasForeignKey(p => p.RentalRequestId)
            //    .OnDelete(DeleteBehavior.Restrict); // No cascade
        }
    }
}
