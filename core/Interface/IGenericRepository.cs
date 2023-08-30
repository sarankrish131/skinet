
using core.Entities;
using core.Specification;

namespace core.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetbyIdAsync (int id);
        Task<IReadOnlyList<T>> ListAllAsync ();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
    }
}