using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Web_services.Entidade.Entidade
{
    public class NotaFicalProduto
    {
        public int NotaFiscalId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
    }
}
