using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }   
    }
}
