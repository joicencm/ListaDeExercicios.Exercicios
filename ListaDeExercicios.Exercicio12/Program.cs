namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
            #region imput de dados

            #endregion

            #region processamento
            for (int n = 101; n < 200; n += 2)                          
                Console.WriteLine(n);            
            #endregion

            #region output dos dados

            #endregion

            Console.ReadLine();
        }
    }
}
