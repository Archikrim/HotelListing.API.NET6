using HotelListing.Api.Core.Models;

namespace HotelListing.Api.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);

        Task<TResult> GetAsync<TResult>(int? id);

        Task<List<T>> GetAllAsync();

        Task<List<TResult>> GetAllAsync<TResult>();

        Task<PageResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);

        Task<T> AddAsync(T entity);

        Task<TResult> AddAsync<TSourse, TResult>(TSourse sourse);

        Task UpdateAsync(T entity);

        Task UpdateAsync<TSourse>(int id, TSourse sourse);

        Task DeleteAsync(int id);

        Task<bool> Exists(int id);
    }
}
