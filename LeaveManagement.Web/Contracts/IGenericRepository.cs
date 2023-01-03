namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<int> GetCountAsync();
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
        Task UpdateAsync(T entity);
        

    }
}
