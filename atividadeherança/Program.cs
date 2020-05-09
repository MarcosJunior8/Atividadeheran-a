using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeherança
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Marlon", "Eloi Mendes", "(35)3264-1111");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 316.12;
            Console.WriteLine("Fornecedor,saldo de :" + f.obterSaldo());

            Colaborador c = new Colaborador("Jonny", "Belem do para", "(91)3205-9000");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Impostos = 2;
            Console.WriteLine("Colaborador,salario: " + c.calcularSalario());

            Administrador a = new Administrador("Hugo", "Varginha", "(35)3222-9204");
            a.CodSetor = 30;
            a.SalarioBase = 818.13;
            a.Impostos = 2;
            a.AjudaDeCusto = 314.07;
            Console.WriteLine("Admistrador, salario: " + a.calcularSalario());

            Operario o = new Operario("Marcio", "Varginha", "(35)3212-2019");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Impostos = 2;
            o.ValorProducao = 117.09;
            o.Comissao = 3;
            Console.WriteLine("Operario, salario: " + o.calcularSalario());

            Vendedor v = new Vendedor("Rodrigo", "Eloi Mendes", "(35)3264-2119");
            v.CodSetor = 30;
            v.SalarioBase = 818.13;
            v.Impostos = 2;
            v.ValorVendas = 518.22;
            v.Comissao = 5;
            Console.WriteLine("Vendedor, salario: " + v.calcularSalario());

            Console.ReadKey();
        }
    }
}
