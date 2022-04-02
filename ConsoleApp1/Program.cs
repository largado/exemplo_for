using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorDeRendimento = 1.0036;

            for(int contador = 1; contador <=5; contador++ )
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorDeRendimento;
                }

                fatorDeRendimento += 0.0010;

            }

            Console.WriteLine(" resultado final " + fatorDeRendimento);



            Console.ReadLine();

        }
    }
}
