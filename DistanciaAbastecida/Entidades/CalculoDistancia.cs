using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaAbastecida.Entidades
{
    public class CalculoDistancia
    {
        public void CapturarValores()
        {
            Console.WriteLine("========================================\n");
            Console.WriteLine("========= CALCULO DE DISTANCIA =========\n");
            Console.WriteLine("========================================\n");
            Console.Write("\nQual a quantidade de combustivel adicionada no veículo? (litros): ");
            var quantidadeCombustivel = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nQual o consumo médio do veiculo? (Km/l): ");
            var quilometragem = Convert.ToDouble(Console.ReadLine());

            var valorValidado = ValidarOsValores(quantidadeCombustivel, quilometragem);

            if (valorValidado == false)
            {
                Console.WriteLine("Houve um erro nos valores informado!");       
            }
            CalcularTotal(quantidadeCombustivel, quilometragem);
        }

        private bool ValidarOsValores(double quantidadeCombustivel, double quilometragem)
        {
            if (quantidadeCombustivel <= 0.0 || quilometragem <= 0.0)
            {
                Console.WriteLine("\nO valor não pode ser menor ou igual a zero!");
                return false;
            }
            return true;
        }

        public void CalcularTotal(double quantidadeCombustivel, double quilometragem)
        {
            double total = quilometragem * quantidadeCombustivel;
            Console.WriteLine($"\nA distancia máxima que seu veículo pode percorrer é {total.ToString("N2")} (Km)");
        }
    }
}
