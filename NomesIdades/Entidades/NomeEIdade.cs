using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesIdades.Entidades
{
    public class NomeEIdade
    {
        List<string> Nomes = new List<string>();
        List<int> Idades = new List<int>();
        public void CapturaValores()
        {
            var nomeMaisVelho = "";
            var idadeMaisVelho = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("==================================\n");
                Console.WriteLine("========= NOMES E IDADES =========\n");
                Console.WriteLine("==================================\n");
                Console.Write("\nDigite seu nome: ");
                var nome = Console.ReadLine();

                Console.Write($"\n{nome}, digite sua idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());

                if (idade > 0)
                {
                    if (idade > idadeMaisVelho)
                    {
                        idadeMaisVelho = idade;
                        nomeMaisVelho = nome;

                    }
                    Nomes.Add(nome);
                    Idades.Add(idade);
                    Console.Clear();
                    }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nO valor não pode ser igual ou menor a 0! Tente novamente.\n");
                    CapturaValores();
                }
            }
            TratarValores(nomeMaisVelho, idadeMaisVelho);
        }

        public void TratarValores(string nomeMaisVelho, int idadeMaisVelho)
        {
            Console.Clear();
            Console.WriteLine("============ LISTA DE NOMES================\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Nomes[i] + "  " + Idades[i]);
            }
            Console.WriteLine($"\nA pessoa mais velha é {nomeMaisVelho}, sua idade atual é {idadeMaisVelho}");
        } 
    }
}
