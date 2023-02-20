using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class PrimeiroDia
    {
        public static void ContarLetrasEPalavras()
        {
            int NumeroDePalavras = 0;
            int NumeroDeCaracteres = 0;
            Console.WriteLine("Digite a entrada: ");
            string? entrada = Console.ReadLine();
            if (entrada == null)
            {
                Console.WriteLine("Entrada nula");
            }
            else if (entrada == "")
            {
                Console.WriteLine("Nenhum caractere detectado.");
            }
            else
            {
                NumeroDeCaracteres = entrada.Length;
                NumeroDePalavras = entrada.Split(' ').Length;
                // Se o usuario digitar apenas espaço, haverão caracteres mas não palavras
                if (NumeroDeCaracteres + 1 == NumeroDePalavras)
                {
                    NumeroDePalavras = 0;
                }
                Console.WriteLine();
                Console.WriteLine($"O texto digitado possui {NumeroDeCaracteres} caracteres.");
                Console.WriteLine($"O texto digitado possui {NumeroDePalavras} palavras.");
                Console.ReadKey();
            }
        }
    }
}