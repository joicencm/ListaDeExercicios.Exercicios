namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        /*
         Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
         múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
         ambos, use "FizzBuzz".
         */
        static void Main(string[] args)
        {
            #region imput de dados
            #endregion

            #region processamento
            for (int n =1; n <=100; n++)
            {
                if (n % 3 == 0 & n % 5 == 0)
                    Console.WriteLine("FizzBuzz");

                else if (n % 3 == 0)
                    Console.WriteLine("Fizz");

                else if (n % 5 == 0)
                    Console.WriteLine("Buzz");

                else
                    Console.WriteLine(n);
            }
            #endregion

            #region output dos dados
            #endregion

            Console.ReadLine();
        }
    }
}
