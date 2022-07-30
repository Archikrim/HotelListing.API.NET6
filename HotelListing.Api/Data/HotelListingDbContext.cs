using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Ukraine",
                        ShortName = "UA"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Jamaica",
                        ShortName = "JM"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Great Britain",
                        ShortName = "GB"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Poland",
                        ShortName = "PL"
                    }
                );
            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "InterContinental",
                        Address = "Kyiv",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Sandal Resort and Spa",
                        Address = "Negril",
                        CountryId = 2,
                        Rating = 4.3
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Comfort Suites",
                        Address = "London",
                        CountryId = 3,
                        Rating = 4.4
                    },
                    new Hotel
                    {
                        Id = 4,
                        Name = "Hayatt",
                        Address = "Warsaw",
                        CountryId = 4,
                        Rating = 4.4
                    }
                );
        }
    }
}
