using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA380_Loja_Web_services.Bll_.Interface
{
    public interface IRepositoryBLL<T>
    {
        bool Delete(int p);
        bool SaveOrUpdate(T p);
        IList<T> GetList();
       

    }
}
