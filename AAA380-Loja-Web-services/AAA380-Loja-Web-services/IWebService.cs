using Loja_Web_services.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static AAA380_Loja_Web_services.DataContract.Media;

namespace AAA380_Loja_Web_services
{
    
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        bool SaveOrUpdateProduto(Produto product);

    
        [OperationContract]
        bool SaveOrUpdateNota(NotaFiscal nota);

        [OperationContract]
        bool DeleteProduto(int id);

        [OperationContract]
        bool DeleteNota(int id);

        [OperationContract]
        Produto GetProdutoByID(int id);

        [OperationContract]
        IList<Produto> GetProdutoByNameDESc(string nome,string descricao);

        [OperationContract]
        IList<Produto> GetProdutos();

        [OperationContract]
        IList<NotaFiscal> GetNotas();

        [OperationContract]
        NotaFiscal AddGridProduct(Produto produto, NotaFiscal notaFiscal);

        [OperationContract]
        NotaFiscal RemoveProduct(int id, NotaFiscal notaFiscal);

        [OperationContract]
        double SumPrice(NotaFiscal notaFiscal);

    }


    // TODO: Adicione suas operações de serviço aqui
}


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
