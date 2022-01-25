using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_git_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int n1, n2, resultado;

            Console.WriteLine("Digite qualquer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine("O Resultado é: " + resultado);

            Console.ReadKey();
        }

    }
}
