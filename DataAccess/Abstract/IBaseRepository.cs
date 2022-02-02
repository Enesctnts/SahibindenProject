using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBaseRepository <T>
    {
        void Kaydet(T entity);
        List<T> Siralama();
    }
}
