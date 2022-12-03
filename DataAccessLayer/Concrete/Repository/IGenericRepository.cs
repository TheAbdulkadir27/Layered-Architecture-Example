using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T delete)
        {
            using (var data = new DbDataContext())
            {
                data.Remove(delete);
                data.SaveChanges();
            }
        }

        public T Getbyid(int id)
        {
            using (var data =new DbDataContext())
            {
               return data.Set<T>().Find(id);
            }
        }

        public List<T> Getlist()
        {
            using (var data = new DbDataContext())
            {
                return data.Set<T>().ToList();
            }
        }
        public void Update(T update)
        {
            using (var data = new DbDataContext())
            {
                data.Update(update);
                data.SaveChanges();
            }
        }
        public void İnsert(T insert)
        {
            using (var data = new DbDataContext())
            {
                data.Add(insert);
                data.SaveChanges();
            }
        }
    }
}
