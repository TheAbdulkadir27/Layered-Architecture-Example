using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class,new()
    {
        void İnsert(T insert);
        void Delete(T delete);
        void Update(T update);
        T Getbyid(int id);
        List<T> Getlist();
    }
}
