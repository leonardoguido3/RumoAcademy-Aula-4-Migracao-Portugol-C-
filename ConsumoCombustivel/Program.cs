using ConsumoCombustivel.Entidades;
namespace ConsumoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoConsumo calculo = new CalculoConsumo();
            calculo.CapturaValores();
        }
    }
}