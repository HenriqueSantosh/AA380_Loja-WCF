using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Web_services.Entidade.Entidade
{
    [DataContract]
    public class Produto
    {
        
        [DataMember]
        public int Id { get;  set; }

        [DataMember]
        public string Nome { get;  set; }

        [DataMember]
        public string Descricao { get;  set; }

        [DataMember]
        public double Preco { get;  set; }
     
    }
}
