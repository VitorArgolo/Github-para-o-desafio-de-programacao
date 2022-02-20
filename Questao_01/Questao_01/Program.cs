using System;


namespace Questao_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                LoopEscada();
                Console.Write("Digite as teclas \"S\" e \"ENTER\" para sair do programa\n\r ou apenas \"ENTER\" para continuar.");
                opcao = (Console.ReadLine()).ToUpper();
            } while (opcao != "S");
        }
        public static void LoopEscada()
        {
            string asterisk = "*";
            string space = " ";
            int n;

            Console.Clear();

            Console.WriteLine("*** EXERCICIO #01 - CAPGEMINI - CONSTRUTOR DE ESCADAS ***" + Environment.NewLine);
            Console.WriteLine("Digite o numero de degrais n. ");
            Console.Write("n = ");
            n = Convert.ToInt16(Console.ReadLine());

            space = space.PadRight(n - 1);
            Console.WriteLine(space + asterisk);
            for (int i = n - 1; i > 0; i--)
            {
                asterisk = asterisk + "*";
                space = space.Remove(space.Length - 1);
                Console.WriteLine(space + asterisk);
            }
        }
    }
}

