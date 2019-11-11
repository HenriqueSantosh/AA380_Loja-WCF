using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_Web_services.Entidade.Entidade;

namespace AAA380_Loja_Web_services.Bll_.Interface
{
    public interface IProdutoBLL
    {

        bool DeleteProduto(int ID);

        bool SaveProduto(Produto produto);

        bool UpdateProduto(Produto produto);

        IList<Produto> GetProdutos();


      }
}
