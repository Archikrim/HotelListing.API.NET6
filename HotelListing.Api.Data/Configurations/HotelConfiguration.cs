using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
