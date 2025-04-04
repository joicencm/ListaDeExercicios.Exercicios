namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro número: ");
            int terceiroNumero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            int maior, meio, menor;

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
            {
                maior = primeiroNumero;
                if (segundoNumero > terceiroNumero)
                {
                    meio = segundoNumero;
                    menor = terceiroNumero;
                }
                else
                {
                    meio = terceiroNumero;
                    menor = segundoNumero;
                }
            }
            else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
            {
                maior = segundoNumero;
                if (primeiroNumero > terceiroNumero)
                {
                    meio = primeiroNumero;
                    menor = terceiroNumero;
                }
                else
                {
                    meio = terceiroNumero;
                    menor = primeiroNumero;
                }
            }
            else
            {
                maior = terceiroNumero;
                if (primeiroNumero > segundoNumero)
                {
                    meio = primeiroNumero;
                    menor = segundoNumero;
                }
                else
                {
                    meio = segundoNumero;
                    menor = primeiroNumero;
                }
            }
            #endregion

            #region output dos dados
            Console.WriteLine($"Ordem decrescente: {maior}, {meio}, {menor}");
            #endregion

            Console.ReadLine();
        }
    }
}