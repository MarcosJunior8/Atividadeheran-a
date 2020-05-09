using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeherança
{
    class Administrador : Colaborador
    {
        private double ajudadeCusto;



        public Administrador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }

        public double AjudaDeCusto
        {
            get { return ajudadeCusto; }
            set { ajudadeCusto = value; }
        }

        public override double calcularSalario()
        {
            return base.calcularSalario() + AjudaDeCusto;
        }
    }
}
