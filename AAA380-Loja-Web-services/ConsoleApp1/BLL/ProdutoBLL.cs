using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_loja.DAO;
using Projeto_loja.Interface;
using Projeto_loja.Entidade;

namespace Projeto_loja.BLL
{
    public class ProdutoBLL
    {
        private IProdutoDAO produtoDAO;
        public ProdutoBLL()
        {
            produtoDAO = new ProdutoDAO();
        }
        public bool Delete(int ID)
        {
            try
            {
                produtoDAO.Delete(ID);
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
                produtoDAO.Save(produto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool Update(Produto produto)
        {
            try
            {
                produtoDAO.Update(produto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public IList<Produto> GetProdutos()
        {
            try
            {

                return produtoDAO.GetProdutos();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
