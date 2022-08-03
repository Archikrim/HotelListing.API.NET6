using AutoMapper;
using HotelListing.Api.Core.Contracts;
using HotelListing.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Core.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries
                .Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
