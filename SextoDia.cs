using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class SextoDia
    {
        public static void EncriptarTexto()
        {
            Dictionary<char, char> cript = new Dictionary<char, char>
                {
                {'A','F'}, {'B','G'}, {'C','H'}, {'D','I'}, {'E','J'}, {'F','K'}, {'G','L'}, {'H','M'}, {'I','N'},
                {'J','O'}, {'K','P'}, {'L','Q'}, {'M','R'}, {'N','S'}, {'O','T'}, {'P','U'}, {'Q','V'}, {'R','W'},
                {'S','X'}, {'T','Y'}, {'U','Z'}, {'V','Ç'}, {'W','A'}, {'X','B'}, {'Y','C'}, {'Z','D'}, {'Ç','E'},
                {' ',' '}, {'.','.'}, {',',','}, {';',';'}, {':',':'}, {'!','!'}, {'?','?'}, {'-','-'}, {'"','"'},
                };
            
            Console.WriteLine("Digite o texto para criptografar: ");
            string? entrada = Console.ReadLine();
            if (String.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Entrada vazia ou nula. Digite uma entrada válida.");
            }
            else
            {
                string saida = "";
                entrada = entrada.ToUpper();
                for(int i = 0; i < entrada.Length; i++)
                {
                    saida += cript.GetValueOrDefault(entrada[i]);
                }
                Console.WriteLine("Resultado:\n");
                Console.WriteLine(saida);
            }
            Console.ReadKey();
        }
    }
}