using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseRepositoryService<T>
    {
        void Kaydet(T entity);
        List<T> Siralama();
    }
}
