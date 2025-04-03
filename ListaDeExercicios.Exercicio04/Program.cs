namespace ListaDeExercicios.Exercicio04
{
    //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
    // Fahrenheit=(Celsius×9/5)+32
    internal class Program
    {
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite a temperatura da escala Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double fahrenheit = (celsius * 9 / 5) + 32;
            #endregion

            #region output dos dados
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");
            #endregion

            Console.ReadLine();

        }
    }
}