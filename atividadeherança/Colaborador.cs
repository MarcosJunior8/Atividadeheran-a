using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeherança
{
    class Colaborador : Pessoa
    {
        private int codigoSetor;
        private double salarioBase;
        private int imposto;


        public Colaborador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }

        public int CodSetor
        {
            get { return codigoSetor; }
            set { codigoSetor = value; }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        
        public int Impostos
        {
            get { return imposto; }
            set { imposto = value; }
        }

        public virtual double calcularSalario()
        {
            return SalarioBase - (SalarioBase * ((double)Impostos / 100));
        }
    }
}
