namespace ListaDeExercicios.Exercicio03
{
    /*
 Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
    programa deve solicitar ao usuário:
    ● A quilometragem inicial do veículo no início da viagem.
    ● A quilometragem final ao término da viagem.
    ● A quantidade de combustível consumida durante a viagem (em litros).
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o início da viagem: ");
            double inicioViagem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o término da viagem: ");
            double terminoViagem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantidade de combustível consumida durante a viagem: ");
            double qtCombustivel = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double quilometragemPercorrida = terminoViagem - inicioViagem;

            // Calculando o consumo de combustível por quilômetro
            double consumoPorKm = qtCombustivel / quilometragemPercorrida;
            #endregion

            #region output dos dados
            Console.WriteLine($"O consumo de combustível por quilômetro percorrido é: {consumoPorKm:F2} litros/km");
            #endregion

            Console.ReadLine();
        }
    }
}