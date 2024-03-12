using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Infrastructure.GestFact.DAL
{
    public interface IGestFactDAO<T> where T : class
    {
        T? Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        Task<T?> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        List<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}