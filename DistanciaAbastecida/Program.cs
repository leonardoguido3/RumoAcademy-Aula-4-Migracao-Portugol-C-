using DistanciaAbastecida.Entidades;

namespace DistanciaAbastecida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoDistancia calculo = new CalculoDistancia();
            calculo.CapturarValores();
        }
    }
}