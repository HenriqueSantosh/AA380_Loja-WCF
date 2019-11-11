using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Web_services.Entidade.Entidade
{
    [DataContract]
    public class NotaFiscal
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime DataNota { get; set; }

        [DataMember]
        public float ValorTotal { get; set; }

        [DataMember]
        public IList<Produto> Produtos { get; set; }
    }
}
