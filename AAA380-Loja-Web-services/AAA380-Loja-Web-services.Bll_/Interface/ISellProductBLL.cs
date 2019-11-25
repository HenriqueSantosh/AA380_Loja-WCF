using Loja_Web_services.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA380_Loja_Web_services.Bll_.Interface
{
    public interface ISellProductBLL
    {
        NotaFiscal AddGridProduct(Produto produto, NotaFiscal notaFiscal);

        NotaFiscal RemoveProduct(int id, NotaFiscal notaFiscal);
        
        double SumPrice(NotaFiscal notaFiscal);

    }
}
