using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoComissao.Entidades
{
    public class CalcularComissao
    {
        public void CapturaValores()
        {
            Console.WriteLine("====================================\n");
            Console.WriteLine("========= CALCULO COMISSAO =========\n");
            Console.WriteLine("====================================\n");
            Console.Write("\nDigite seu nome: ");
            var nomeVendedor = Console.ReadLine();
            Console.Write($"\n{nomeVendedor}, qual o valor do seu salário?: (R$)");
            var salario = Convert.ToDouble(Console.ReadLine());
            Console.Write($"\n{nomeVendedor}, qual o total de vendas realizadas no mês? (R$):");
            var vendasMes = Convert.ToDouble(Console.ReadLine());

            var valorValidado = ValidarOsValores(nomeVendedor, salario, vendasMes);

            if (valorValidado == false)
            {
                Console.WriteLine("Houve um erro com os valores informado!");           
            }
            CalculaComissao(nomeVendedor, salario, vendasMes);
        }

        private bool ValidarOsValores(string nomeVendedor, double salario, double vendasMes)
        {
            if (nomeVendedor == null)
            {
                Console.WriteLine("\nO nome não pode ser em branco!");
                return false;
            }
            else if (salario <= 0 || vendasMes <= 0)
            {
                Console.WriteLine("\nO valor não pode ser menor ou igual a zero!");
                return false;
            }
            return true;
        }

        public void CalculaComissao(string nomeVendedor, double salario, double vendasMes)
        {
            double comissaoVendedor = vendasMes * 0.15;
            double salarioTotal = salario + comissaoVendedor;
            Console.WriteLine($"\nOlá {nomeVendedor}.\n \nseu salário fixo é de: R$ {salario.ToString("C2")}. \nSua comissão foi de: R$ {comissaoVendedor.ToString("C2")}. \nSeu salário total foi de: R$ {salarioTotal.ToString("C2")}");
        }
    }
}
