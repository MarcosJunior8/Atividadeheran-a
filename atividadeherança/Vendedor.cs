using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeherança
{
    class Vendedor : Colaborador
    {
        private double valorVendas;
        private int comissao;   


        public Vendedor (string Nome, string End,string Tel) : base(Nome, End, Tel)
        {

        }


        public double ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
        }

        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public override double calcularSalario()
        {
            double valorComissao = ValorVendas - (ValorVendas * ((double)Comissao / 100));

            return base.calcularSalario() + valorComissao;
        }
    }
}
