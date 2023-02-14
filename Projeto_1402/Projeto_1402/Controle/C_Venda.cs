using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_1402.Modelo;

namespace Projeto_1402.Controle
{
   public class C_Venda
    {
       public Vendas calculaVendas(Vendas obj)
       {
           /*double qa = obj.Quantidade;
           double va = obj.Valor;*/

           obj.Total = obj.Quantidade * obj.Valor;

           return obj;
       }
    }
}
