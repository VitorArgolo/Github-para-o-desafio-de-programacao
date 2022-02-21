using System;
using System.Collections.Generic;

namespace Questao_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int contador = 0;
            List<string> listaLetras = new List<string>();
            List<string> listaLetrasAuxiliar = new List<string>();
            List<string> listaLetrasInvertidas = new List<string>();


            Console.WriteLine("QUESTÃO 03 - Anagramas");
            Console.Write("Didite algo:");
            palavra = Console.ReadLine();


            foreach (char item in palavra)
            {
                listaLetras.Add(item.ToString());
                Console.WriteLine(item);
            }
            listaLetrasAuxiliar.AddRange(listaLetras);
            for (int i = 0; i < listaLetras.Count - 1; i++)
            {
                string letraTemporaria = listaLetras[i];

                listaLetras.RemoveAt(i);

                if (listaLetras.Contains(letraTemporaria))
                {
                    contador++;
                }
            }
            //ov vo
            listaLetras.Clear();
            for (int i = 0; i < listaLetrasAuxiliar.Count - 1; i++)
            {
                string palavraTemporaria = listaLetrasAuxiliar[i] + listaLetrasAuxiliar[i + 1];
                listaLetras.Add(palavraTemporaria);
                palavraTemporaria = listaLetrasAuxiliar[i + 1] + listaLetrasAuxiliar[i];
                listaLetrasInvertidas.Add(palavraTemporaria);
            }
            listaLetrasInvertidas.RemoveAt(0);
            for (int i = 0; i < listaLetras.Count-1; i++)
            {
                string palavraTemporaria = listaLetras[i];
                for (int j = 0; j < listaLetrasInvertidas.Count; j++)
                {
                    if (palavraTemporaria == listaLetrasInvertidas[j])
                    {
                        contador++;
                    }
                }
                
            }
            foreach (string item in listaLetrasInvertidas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"A palavra possui: {contador} anagramas.");
            Console.ReadLine();
        }
    }
}
