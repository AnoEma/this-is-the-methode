using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarioMedio mm = new SalarioMedio();
            SalarioMedio mn = new SalarioMedio();

            Console.WriteLine("Dados do primeiro funcinário");
            Console.Write("Ditige seu Nome completo: ");
            mm.Nome = Console.ReadLine();
            Console.Write("salário: ");
            mm.salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Digite seu nome completo: ");
            mn.Nome = Console.ReadLine();
            mn.salario = decimal.Parse(Console.ReadLine());

            decimal medio = (mm.salario + mn.salario) / 2;

            Console.WriteLine("Salário medio é : " + medio);

        }
    }
}
