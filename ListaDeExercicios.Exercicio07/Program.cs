namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        //Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            bool ehPrimo = true;

            // Se o número for menor ou igual a 1, ele não é primo
            if (numero <= 1)
            {
                ehPrimo = false;
            }
            else
            {
                // Verifica se o número tem algum divisor além de 1 e ele mesmo
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }
            #endregion

            #region output dos dados
            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
