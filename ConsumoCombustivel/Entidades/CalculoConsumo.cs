using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoCombustivel.Entidades
{
    public class CalculoConsumo
    {
        public void CapturaValores()
        {
            Console.WriteLine("===================================\n");
            Console.WriteLine("========= CALCULO CONSUMO =========\n");
            Console.WriteLine("===================================\n");
            Console.Write("\nQual a quantidade de combustivel adicionada no veículo? (litros): ");
            var quantidadeCombustivel = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nQual a quilometragem rodada? (Km): ");
            var quilometragem = Convert.ToDouble(Console.ReadLine());

            var valorValidado = ValidarOsValores(quantidadeCombustivel, quilometragem);

            if (valorValidado == false)
            {
                Console.WriteLine("Houve um erro com os valores informado!");
            }
            else
            {
                CalcularConsumo(quantidadeCombustivel, quilometragem);
            }
        }

        private bool ValidarOsValores(double quantidadeCombustivel, double quilometragem)
        {
            if (quantidadeCombustivel <= 0.0 || quilometragem <= 0.0)
            {
                Console.WriteLine("\nO valor não pode ser menor que zero!");
                return false;
            }
            return true;
        }

        public void CalcularConsumo(double quantidadeCombustivel, double quilometragem)
        {
            double media = quilometragem / quantidadeCombustivel;
            Console.WriteLine($"\nO consumo médio do seu veículo é: {media.ToString("C2")} Km/l");
        }
    }
}
