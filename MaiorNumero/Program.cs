using System;

namespace MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º Declarar variáveis e respectivos tipos
            int num1 = 0, num2 = 0;

            // 2º Solicitar e ler os números
            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            //3º Processamento

            if (num1>num2)
            {
                // 4º Escrever o valor
                Console.WriteLine("O primeiro número é o maior.");
            }

            else if (num1<num2)
            {
                // 4º Escrever o valor
                Console.WriteLine("O segundo número é o maior.");
            }

            else
            {
                // 4º Escrever o valor
                Console.WriteLine("Os número são iguais.");
            }

            //5º Efectuada a leitura do código
            Console.ReadLine();
            Console.Clear();
        }
    }
}
