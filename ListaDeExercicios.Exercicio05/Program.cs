namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base
        //e o total de vendas.
        //A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o salario do vendedor");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a vendas do vendedor");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o  percentual de comissão sobre o total de vendas (em %");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double salarioTotal = salarioBase + (percentualComissao / 100) * vendas;
            #endregion

            #region output dos dados
            Console.WriteLine($"O salário total do vendedor é: R${salarioTotal:F2}");
            #endregion

            Console.ReadLine();

        }
    }
}
