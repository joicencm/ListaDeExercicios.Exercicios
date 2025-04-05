namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
            #region imput de dados
            Console.WriteLine("Digita o numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            #endregion

            #region processamento
            bool resultado = (numero % 2 == 0);
            #endregion

            #region output dos dados
            if (resultado)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
            #endregion

            Console.ReadLine();

        }
    }
}
