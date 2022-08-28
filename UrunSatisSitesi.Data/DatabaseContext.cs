using Microsoft.EntityFrameworkCore;
using UrunSatisSitesi.Entities;

namespace UrunSatisSitesi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {


        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Slider { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-HS2HO2U8; Database=UrunSatisSitesi;trusted_connection =true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().Property(a => a.Name)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)

                ;
            modelBuilder.Entity<AppUser>().Property(a => a.Surname).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
            modelBuilder.Entity<AppUser>().Property(a => a.Email).IsRequired().HasColumnType("nvarchar(50)");
            modelBuilder.Entity<AppUser>().Property(a => a.Phone).HasColumnType("nvarchar(15)");
            modelBuilder.Entity<AppUser>().Property(a => a.Username).HasColumnType("nvarchar(15)");
            modelBuilder.Entity<AppUser>().Property(a => a.Password).HasColumnType("nvarchar(15)").IsRequired();
            modelBuilder.Entity<AppUser>().HasData
                (new AppUser
                {
                    Id = 1,
                    Username = "Admin",
                    Password = "123",
                    Email = "admin@urunsatissitesi.com",
                    IsActive=true,
                    IsAdmin=true,
                    Name="Admin",
                    Surname="Administrator"

                });             

            
            base.OnModelCreating(modelBuilder);
        }
    }
}