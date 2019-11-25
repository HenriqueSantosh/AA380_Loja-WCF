using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AAA380_Loja_Web_services.DataContract;
using Loja_Web_services.Entidade.Entidade;
using AAA380_Loja_Web_services.Bll_.Interface;
using AAA380_Loja_Web_services.Bll_.BLL;



namespace AAA380_Loja_Web_services
{
 
    public class WebService : IWebService
    {
        IProdutoBLL produtoBll;
        INotaBLL notaBLL;
        ISellProductBLL sellProductBLL;
        public WebService()
        {
            produtoBll = new ProdutoBLL();
            notaBLL = new NotaBLL();
            sellProductBLL = new SellProductBLL();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool SaveOrUpdateProduto(Produto p)
        {
            return produtoBll.SaveOrUpdate(p);
        }


        public bool DeleteProduto(int id)
        {
           return produtoBll.Delete(id);
        }

        public IList<Produto> GetProdutos()
        {
           return produtoBll.GetList();
        }

        public bool SaveorUpdateNota(NotaFiscal nota)
        {
            return notaBLL.SaveOrUpdate(nota);
        }

        public IList<NotaFiscal> GetNotas()
        {
            return notaBLL.GetList();
        }

 
        public bool DeleteNota(int id)
        {
            return notaBLL.Delete(id);
        }

        public bool SaveOrUpdateNota(NotaFiscal nota)
        {
            return notaBLL.SaveOrUpdate(nota);
        }

        public Produto GetProdutoByID(int id)
        {
            return produtoBll.GetProdutoByID(id);
        }

        public IList<Produto> GetProdutoByNameDESc(string nome, string descricao)
        {
            return produtoBll.GetProdutoByNameDESc(nome, descricao);
        }

        public NotaFiscal AddGridProduct(Produto produto, NotaFiscal notaFiscal)
        {
            return sellProductBLL.AddGridProduct(produto, notaFiscal);
        }

        public NotaFiscal RemoveProduct(int id, NotaFiscal notaFiscal)
        {
            return sellProductBLL.RemoveProduct(id, notaFiscal);
        }

        public double SumPrice(NotaFiscal notaFiscal)
        {
            return sellProductBLL.SumPrice(notaFiscal);
        }
    }
}
