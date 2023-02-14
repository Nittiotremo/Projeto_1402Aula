using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1402.Modelo
{
    public class Vendas
    {
        public String Nome { get; set;}
        public Double Total { get; set; }
        public Double Quantidade { get; set; }
        public Double Valor { get; set; }

        public Vendas(String nome, double Quantidade, Double Valor)
        {
            this.Nome = nome;
            this.Quantidade = Quantidade;
            this.Valor = Valor;
        }

        public Vendas()
        {
            Console.WriteLine("Objeto Vazio");
        }
    }
}
