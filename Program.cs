using System;

namespace Exercicio_1___Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de meses que deseja calcular os dias");

            var nMeses = Convert.ToInt32(Console.ReadLine());

            var nrTotalDias = 30 * nMeses;

            Console.WriteLine("Em " + nMeses + " mese(s), o número total de dias é de: " + nrTotalDias + " dia(s) - considerando que todos os meses tem 30 dias");

            Console.ReadLine();
        }
    }
}
