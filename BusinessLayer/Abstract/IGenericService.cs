using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void İnsert(T insert);
        void Delete(T delete);
        void Update(T Update);
        T getbyid(int id);
        List<T> GetList();
    }
}
