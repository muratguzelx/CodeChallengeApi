using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure.Base
{
    public interface IRepository<T> where T : class
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);

        int MaxId(Expression<Func<T, int>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
    }
}
