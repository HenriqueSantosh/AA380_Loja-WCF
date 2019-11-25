using AAA380_Loja_Web_services.Bll_.Interface;
using Loja_Web_services.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA380_Loja_Web_services.Bll_.BLL
{
    public class SellProductBLL : ISellProductBLL
    {
        public SellProductBLL()
        {

        }

        public NotaFiscal AddGridProduct(Produto produto, NotaFiscal notaFiscal)
        {
           
            if (notaFiscal.Produtos == null)
            {
                notaFiscal.Produtos =  new List<NotaFicalProduto>();
            }
            else
            {
            {
                var list = ConvertArrayToList(notaFiscal);
                notaFiscal.Produtos = new List<NotaFicalProduto>(list);
            }

            try
            {
                notaFiscal.AddProduct(produto);
                return notaFiscal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NotaFiscal RemoveProduct(int id, NotaFiscal notaFiscal)
        {
            var list = ConvertArrayToList(notaFiscal);
            notaFiscal.Produtos = new List<NotaFicalProduto>(list);
            try
            {
                 var prod = notaFiscal.Produtos.FirstOrDefault(x => x.Produto.Id == id);
                 notaFiscal.Produtos.Remove(prod);
                return notaFiscal;
            }
             catch (Exception ex)
            {
                throw ex;
            }
        }

        public double SumPrice(NotaFiscal notaFiscal)
        {
            try
            {
                return notaFiscal.Produtos.Sum(x => x.Produto.Preco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<NotaFicalProduto> ConvertArrayToList(NotaFiscal notaFiscal)
        {
            var list = new List<NotaFicalProduto>(notaFiscal.Produtos);
            return list;
        }

    }
}
