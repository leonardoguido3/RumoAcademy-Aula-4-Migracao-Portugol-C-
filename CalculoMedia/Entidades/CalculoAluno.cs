using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMedia.Entidades
{
    public class CalculoAluno
    {
        public void CapturarValores()
        {
            Console.WriteLine("=================================\n");
            Console.WriteLine("========= CALCULO MÉDIA =========\n");
            Console.WriteLine("=================================\n");
            Console.WriteLine(Environment.NewLine);
            Console.Write("\nQuantos alunos possui na turma? : ");
            var quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            var valorValidado = ValidarOsValores(quantidadeAlunos);

            if (valorValidado == false)
            {
                Console.WriteLine("Houve um erro com os valores informado!");
                
            }
            CalculaMediaAluno(quantidadeAlunos);
        }

        private bool ValidarOsValores(int quantidadeAlunos)
        {
            if (quantidadeAlunos <= 0)
            {
                Console.WriteLine("\nO valor não pode ser menor ou igual a zero!");
                return false;
            }
            return true;
        }

        public void CalculaMediaAluno(int quantidadeAlunos)
        {
            int contador = 0;
            double notaAluno = 0.0;
            double total = 0.0;

            while (contador < quantidadeAlunos)
            {
                Console.Clear();
                Console.Write($"\nEscreva a nota do aluno  {contador + 1}: ");
                notaAluno = Convert.ToDouble(Console.ReadLine());
                total += notaAluno;
                contador++;
            }

            double media = (total / quantidadeAlunos);
            Console.WriteLine($"\nA média da turma foi de:  {media.ToString("C2")}");
        }
    }
}
