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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool SaveProduto(Produto p);

        [OperationContract]
        bool UpdateProduto(Produto p);

        [OperationContract]
        bool SaveNota(Produto p);

        [OperationContract]
        bool UpdateNota(Produto p);

        [OperationContract]
        bool DeleteProduto(int id);
       
        [OperationContract]
        IList<Produto> GetProdutos();

        [OperationContract]
        IList<NotaFiscal> GetNotas();

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
