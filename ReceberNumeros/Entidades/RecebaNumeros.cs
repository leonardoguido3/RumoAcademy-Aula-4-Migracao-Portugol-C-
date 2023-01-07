﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReceberNumeros.Entidades
{
    public class RecebaNumeros
    {
        List<int> Numeros = new List<int>();
        public void CapturaValores()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Clear();
                Console.WriteLine("================================\n");
                Console.WriteLine("========= LISTA NUMERO =========\n");
                Console.WriteLine("================================\n");
                Console.Write($"\nDigite o  {i + 1}° numero: ");
                var numero= Convert.ToInt32(Console.ReadLine());

                Numeros.Add(numero);
            }

            PercorreValores();
        }

        public void PercorreValores()
        {
            for (int i = 0; i < 15; i++)
            {
                if (Numeros[i] >= 0 )
                {
                    var positivo = Numeros[i];
                    Console.WriteLine($"O {i + 1}° é: {positivo}");
                }
            }
        }
    }
}
