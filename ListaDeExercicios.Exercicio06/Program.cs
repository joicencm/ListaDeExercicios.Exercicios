namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite a nota da primeira prova");
            double primeiraProva = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a nota da segunda prova");
            double segundaProva = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            // Definindo os pesos para cada prova
            double pesoPrimeiraProva = 3;
            double pesoSegundaProva = 7;

            // Calculando a média ponderada
            double mediaPonderada = (primeiraProva * pesoPrimeiraProva + segundaProva * pesoSegundaProva)
                                    / (pesoPrimeiraProva + pesoSegundaProva);
            #endregion

            #region output dos dados
            Console.WriteLine($"A média ponderada das provas é: {mediaPonderada}");
            #endregion

            Console.ReadLine();

        }
    }
}
