using System;
using System.Globalization;

namespace ExercicioFuncionarioOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+f.Nome +", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
