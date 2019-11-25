using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_Web_DAO.DAO;
using Loja_Web_DAO.Interface;
using Loja_Web_services.Entidade.Entidade;
using AAA380_Loja_Web_services.Bll_.Interface;


namespace AAA380_Loja_Web_services.Bll_.BLL
{
    public class ProdutoBLL : IProdutoBLL, IDisposable
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

        public bool SaveOrUpdate(Produto product)
        {
            try
            {
                try
                {
                    if (product.Id == 0)
                    {
                        return produtoDAO.Save(product);
                    }
                    return produtoDAO.Update(product);
                }
                catch (Exception ex)
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        private bool UpdateProduct(Produto product)
        {
            try
            {
                produtoDAO.Update(product);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private bool SaveProduct(Produto product)
        {
            try
            {
                produtoDAO.Save(product);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public IList<Produto> GetList()
        {
            try
            {
                return produtoDAO.GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produto GetProdutoByID(int id)
        {
            try
            {
                return produtoDAO.Search(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Produto> GetProdutoByNameDESc(string nome, string descricao)
        {
            try
            {
                return produtoDAO.SearchByNAme(nome, descricao);
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
    }
}       

