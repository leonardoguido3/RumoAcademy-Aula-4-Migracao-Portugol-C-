using CalculoComissao.Entidades;

namespace CalculoComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando a classe e chamando a função para captura de valores
            CalcularComissao calculo = new CalcularComissao();
            calculo.CapturaValores();
        }
    }
}