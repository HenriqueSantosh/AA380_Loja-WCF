using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAA380_Loja_Web_services.DAO.Interface.DAO;
using AAA380_Loja_Web_services.DAO.DAO;
using Loja_Web_services.Entidade.Entidade;
using AAA380_Loja_Web_services.Bll_.Interface;


namespace AAA380_Loja_Web_services.Bll_.BLL
{
    public class ProdutoBLL : IProdutoBLL
    {
        private IProdutoDAO produtoDAO;
        public ProdutoBLL()
        {
            produtoDAO = new ProdutoDAO();
        }
        public bool DeleteProduto(int ID)
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


        public bool SaveProduto(Produto produto)
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

        public bool UpdateProduto(Produto produto)
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

                return produtoDAO.GetList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
