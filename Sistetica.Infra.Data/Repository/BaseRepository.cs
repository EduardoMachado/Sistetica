using Sistetica.Domain.Entities;
using Sistetica.Domain.Interfaces;
using Sistetica.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistetica.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MySqlContext context = new MySqlContext();
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);

        }

        //public IList<T> SelectAll()
        //{
        //    return context.Set<T>().ToList();
        //}

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
