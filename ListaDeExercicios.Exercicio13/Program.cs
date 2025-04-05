namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        /*
         Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
         resultado.
            Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
         */
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("digite valor inicial");
            int valorInicial = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;
            string sequencia = "";
            #endregion

            #region processamento
            for (int n = valorInicial; n >= 1; n--)
            {
                fatorial *= n;
                sequencia += n;

                if (n > 1)
                    sequencia += " x " ;
            }
            #endregion

            #region output dos dados
            Console.WriteLine($"{sequencia} = {fatorial}");
            #endregion

            Console.ReadLine();
        }
    }
}
