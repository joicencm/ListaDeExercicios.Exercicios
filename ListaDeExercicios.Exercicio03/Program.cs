namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        //crie um programa para calcular o volumme de uma caixa retangular
        //VOLUME_DA_CAIXA = COMPRIMENTO * LARGARA * ALTURA
        static void Main(string[] args)
        {
            #region imput de dados
            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal altrura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento
            decimal resultado = comprimento * largura * altrura;
            #endregion

            #region output dos dados
            Console.WriteLine($"O volume da caixa é de {resultado}.");
            #endregion

            Console.ReadLine();
        }
    }
}
