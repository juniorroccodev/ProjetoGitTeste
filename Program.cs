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

            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out n2);

            resultado = n1 + n2;
            Console.WriteLine($"O Resultado é: {resultado}");

            Console.ReadKey();
        }

    }
}
