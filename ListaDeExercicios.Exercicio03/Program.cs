namespace ListaDeExercicios.Exercio03
{
    internal class Program
    {
        /*
         Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O 
         programa deve solicitar ao usuário:
            ● A quilometragem inicial do veículo no início da viagem.
            ● A quilometragem final ao término da viagem.
            ● A quantidade de combustível consumida durante a viagem (em litros).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quilometragem inicial da viagem: ");
            double inicio = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a quilometragem final da viagem: ");
            double termino = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite combustível consumida durante a viagem: ");
            double combustível = Convert.ToDouble(Console.ReadLine());

            double consumoPorkm = combustível / (termino - inicio);

            Console.WriteLine($"O consumo de combustível por quilômetro percorrudo foi: {consumoPorkm:F2} litros/km");

            Console.ReadLine();

        }
    }
}
