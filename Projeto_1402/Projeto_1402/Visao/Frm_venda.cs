using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_1402.Visao;
using Projeto_1402.Controle;
using Projeto_1402.Modelo;

namespace Projeto_1402.Visao
{
    public partial class Frm_venda : Form
    {
        public Frm_venda()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();

            v.Nome = Txt_Nome.Text;
            v.Quantidade = Double.Parse(txt_quantidade.Text);
            v.Valor = Double.Parse(Txt_valor.Text);

            C_Venda cv = new C_Venda();

            v = cv.calculaVendas(v);

            Lbl_total.Text = v.Total.ToString();
        }
    }
}
