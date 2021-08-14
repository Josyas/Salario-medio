using System;
using System.Globalization;

namespace Ex_02_OrientacaoObejtc
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double media;

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"Salário média = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
