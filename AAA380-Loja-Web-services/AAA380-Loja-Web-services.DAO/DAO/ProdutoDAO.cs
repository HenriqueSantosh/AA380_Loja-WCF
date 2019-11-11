using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA380_Loja_Web_services.DAO.Interface.DAO;
using Loja_Web_services.Entidade.Entidade;

namespace AAA380_Loja_Web_services.DAO.DAO
{
    public class ProdutoDAO  : IProdutoDAO, IDisposable
    {
       private ProjectDbContext contexto;
        public ProdutoDAO()
        {
            contexto = new ProjectDbContext();
        }
        public bool Delete(int ID)
        {
            try
            {
                Produto produto = contexto.Produtos.Find(ID);
                contexto.Remove(produto);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

       
        public bool Save(Produto produto)
        {
            try
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool Update(Produto produto)
        {
            try
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public IList<Produto> GetList()
        {
            try
            {

                return contexto.Produtos.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
    }
}
