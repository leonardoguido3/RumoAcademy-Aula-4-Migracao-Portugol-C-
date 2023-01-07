using CalculoMedia.Entidades;

namespace CalculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoAluno calculo = new CalculoAluno();
            calculo.CapturarValores();
        }
    }
}