namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o valor do A");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do B");
            int valorB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do C");
            int valorC = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            int soma = valorA + valorB;
            bool resultado = soma < valorC;
            #endregion

            #region output dos dados
            if (resultado)
                Console.WriteLine($"Resultado {valorA} + {valorB} = {soma}. É menor que {valorC}");
            else
                Console.WriteLine($"Resultado {valorA} + {valorB} = {soma}. Não é menor que {valorC}");

            #endregion

            Console.ReadLine();
        }
    }
}
