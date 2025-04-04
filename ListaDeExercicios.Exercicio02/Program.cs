namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volime de Cilindro
        // V= π * r² * h
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region output dos dados
            Console.WriteLine($"O volume do cilindro é: {volume} unidades cúbicas");
            #endregion

            Console.ReadLine();
        }
    }
}
