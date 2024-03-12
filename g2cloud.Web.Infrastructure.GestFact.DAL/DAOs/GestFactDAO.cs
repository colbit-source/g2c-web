using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Infrastructure.GestFact.DAL
{
    public class GestFactDAO<T> : IGestFactDAO<T> where T : class
    {
        public T? Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T? item = null;

            using (var db = new GestFactContext())
            {
                IQueryable<T> dbQuery = db.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include(navigationProperty);

                item = dbQuery
                    .AsNoTracking()
                    .FirstOrDefault<T>(where);
            }
            return item;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T? item = null;
            using (var db = new GestFactContext())
            {
                IQueryable<T> dbQuery = db.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include(navigationProperty);

                item = await dbQuery
                    .AsNoTracking()
                    .FirstOrDefaultAsync<T>(where);
            }
            return item;
        }

        public async Task<T?> GetAsync(GestFactContext context, Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();

            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include(navigationProperty);

            T? item = await dbQuery
                    .AsNoTracking()
                    .FirstOrDefaultAsync<T>(where);

            return item;
        }

        public List<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var db = new GestFactContext())
            {
                IQueryable<T> dbQuery = db.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            }
            return list;
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var db = new GestFactContext())
            {
                IQueryable<T> dbQuery = db.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include(navigationProperty);

                list = await dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToListAsync<T>();
            }
            return list;
        }

        public async Task<List<T>> GetListAsync(GestFactContext context, Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;

            IQueryable<T> dbQuery = context.Set<T>();

            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include(navigationProperty);

            list = await dbQuery
                .AsNoTracking()
                .Where(where)
                .ToListAsync<T>();

            return list;
        }

        public void Add(params T[] items)
        {
            using var db = new GestFactContext();
            foreach (T item in items)
            {
                #region Optional

                /* Descomentar para bd's que no utilicen nulos para valores de cadena, usamos reflection para poner como string empty todos los campos null */
                foreach (var propertyInfo in item.GetType().GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        if (propertyInfo.GetValue(item, null) == null)
                        {
                            if (propertyInfo.CanWrite) { propertyInfo.SetValue(item, string.Empty, null); }
                        }
                    }

                    else if (propertyInfo.PropertyType == typeof(byte[]))
                    {
                        if (propertyInfo.GetValue(item, null) == null)
                        {
                            if (propertyInfo.CanWrite) { propertyInfo.SetValue(item, Array.Empty<byte>(), null); }
                        }
                    }
                }

                #endregion

                db.Entry(item).State = EntityState.Added;
            }
            db.SaveChanges();
        }

        public void Add(GestFactContext context, params T[] items)
        {
            foreach (T item in items)
            {
                #region Optional

                /* Descomentar para bd's que no utilicen nulos para valores de cadena, usamos reflection para poner como string empty todos los campos null */
                foreach (var propertyInfo in item.GetType().GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        if (propertyInfo.GetValue(item, null) == null)
                        {
                            if (propertyInfo.CanWrite) { propertyInfo.SetValue(item, string.Empty, null); }
                        }
                    }

                    else if (propertyInfo.PropertyType == typeof(byte[]))
                    {
                        if (propertyInfo.GetValue(item, null) == null)
                        {
                            if (propertyInfo.CanWrite) { propertyInfo.SetValue(item, Array.Empty<byte>(), null); }
                        }
                    }
                }

                #endregion

                context.Entry(item).State = EntityState.Added;
            }

            context.SaveChanges();
        }

        public void Update(params T[] items)
        {
            using var db = new GestFactContext();
            foreach (T item in items)
            {
                db.Entry(item).State = EntityState.Modified;
            }
            db.SaveChanges();
        }

        public void Update(GestFactContext context, params T[] items)
        {
            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Remove(params T[] items)
        {
            using var db = new GestFactContext();
            foreach (T item in items)
            {
                db.Entry(item).State = EntityState.Deleted;
            }
            db.SaveChanges();
        }

        public void Remove(GestFactContext context, params T[] items)
        {
            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Deleted;
            }

            context.SaveChanges();
        }
    }
}