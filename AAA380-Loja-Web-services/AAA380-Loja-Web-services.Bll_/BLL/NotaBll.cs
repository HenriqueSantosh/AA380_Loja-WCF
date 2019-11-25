using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA380_Loja_Web_services.Bll_.Interface;
using Loja_Web_DAO.Interface;
using Loja_Web_DAO.DAO;
using Loja_Web_services.Entidade.Entidade;

namespace AAA380_Loja_Web_services.Bll_.BLL
{
    public class NotaBLL : INotaBLL, IDisposable
    {
        INotaDAO notaDAO;
        public NotaBLL()
        {
            notaDAO = new NotaDAO();
        }
        public bool Delete(int ID)
        {
            try
            {
                notaDAO.Delete(ID);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;  
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<NotaFiscal> GetList()
        {
            try
            {
                return notaDAO.GetList();
                 
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }


        public bool SaveNota(NotaFiscal nota)
        {
            try
            {
                return notaDAO.Save(nota);

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool SaveOrUpdate(NotaFiscal p)
        {
            try
            {
                var prod = notaDAO.Search(p.Id);
                if (prod == null)
                {
                    return SaveNota(p);
                }
                return UpdateNota(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateNota(NotaFiscal nota)
        {
            try
            {
                return notaDAO.Update(nota);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
