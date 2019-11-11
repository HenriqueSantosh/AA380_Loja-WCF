using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA380_Loja_Web_services.DAO.Interface.DAO
{
     public interface IRepositoryDAO <T>
    {
        bool Save(T p);
        bool Update(T p);
        bool Delete(int id);
        IList<T> GetList();
    }
}
