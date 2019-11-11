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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        IProdutoBLL produto;

        public  Service1()
        {
            produto = new ProdutoBLL();
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

        public bool SaveProduto(Produto p)
        {
            try
            {
                produto.SaveProduto(p);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool UpdateProduto(Produto p)
        {
            try
            {
                produto.UpdateProduto(p);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool DeleteProduto(int id)
        {
            try
            {
                produto.DeleteProduto(id);
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
                return produto.GetProdutos();
               
            }
            catch (Exception ex)
            {
                throw ex;
             
            }
        }

        public bool SaveNota(Produto p)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNota(Produto p)
        {
            throw new NotImplementedException();
        }

        public IList<NotaFiscal> GetNotas()
        {
            throw new NotImplementedException();
        }
    }
}
