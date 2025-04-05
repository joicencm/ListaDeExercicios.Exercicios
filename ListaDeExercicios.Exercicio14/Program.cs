namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        // Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        static void Main(string[] args)
        {
            #region input de dados
            Console.WriteLine("Digite o número limite para a sequência de Fibonacci:");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            int a = 0, b = 1;
            Console.WriteLine("Sequência de Fibonacci até " + numero + ":");

            // Imprime o primeiro número da sequência (0) e depois verifica o número 1
            Console.Write(a + " ");

            #endregion

            #region output dos dados
            while (b <= numero)
            {
                if (b != a)

                    Console.Write(b + " ");

                int sequencia = a + b;  // O próximo número é a soma dos dois anteriores
                a = b;  // Atualiza o valor de 'a' para o próximo número
                b = sequencia;  // Atualiza o valor de 'b' para o próximo número
            }
            #endregion

            Console.ReadLine();
        }
    }
}
