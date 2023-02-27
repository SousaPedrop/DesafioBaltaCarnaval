using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class QuintoDia
    {
        public static void ValorPorExtenso()
        {
            Console.WriteLine("Digite um valor inteiro: ");
            string? valor = Console.ReadLine();
            if (String.IsNullOrEmpty(valor))
            {
                Console.WriteLine("Digite um valor válido.");
            }
            else
            {
                string valorExtenso = "";
                int valorInteiro = int.Parse(valor);

                if (valorInteiro <= 999)
                {
                    valorExtenso += valorInteiro.PegarExtenso();
                }
                else if (valorInteiro > 999 && valorInteiro <= 99999)
                {
                    valorExtenso += (valorInteiro / 1000).PegarExtenso();
                    valorExtenso += " MIL ";
                    if(valor.Contains("00") && !(valor.EndsWith("000")))
                    {
                        valorExtenso += "E ";
                    }
                    valorExtenso += (valorInteiro % 1000).PegarExtenso();
                }

                Console.WriteLine(valorExtenso);
            }
            Console.ReadKey();
        }

        private static string PegarExtenso(this int valor)
        {
            string extenso = "";
            int divisor = 100;
            int indice;

            string[] unidades = {"", "UM", "DOIS", "TRÊS", "QUATRO", "CINCO", "SEIS", "SETE", "OITO", "NOVE",
                                "DEZ","ONZE", "DOZE", "TREZE", "CATORZE", "QUINZE", "DEZESSEIS", "DEZESSETE", "DEZOITO", "DEZENOVE"};
            string[] dezenas = { "", "DEZ", "VINTE", "TRINTA", "QUARENTA", "CINQUENTA", "SESSENTA", "SETENTA", "OITENTA", "NOVENTA" };
            string[] centenas = {"", "CENTO", "DUZENTOS", "TREZENTOS", "QUATROCENTOS", "QUINHENTOS",
                                    "SEICENTOS", "SETECENTOS", "OITOCENTOS", "NOVECENTOS"};

            if (valor == 100)
            {
                return "CEM";
            }
            if (valor == 1)
            {
                return "UM";
            }
            for (int i = 0; i < 3; i++)
            {
                indice = valor / divisor;
                if (divisor == 100)
                {
                    if (centenas[indice] != "")
                    {
                        extenso += $"{centenas[indice]}";
                    }
                    valor = valor - (indice * divisor);
                }
                else if (divisor == 10 && indice > 1)
                {
                    if (extenso == "" || dezenas[indice] == "")
                    {
                        extenso += $"{dezenas[indice]}";
                    }
                    else
                    {
                        extenso += " E ";
                        extenso += dezenas[indice];
                    }
                    valor = valor - (indice * divisor);
                }
                else
                {
                    if ((String.IsNullOrWhiteSpace(extenso) || unidades[indice] == "") && (indice > 1))
                    {
                        extenso += unidades[indice];
                    }
                    else if(divisor == 1 && indice != 0)
                    {
                        extenso += " E ";
                        extenso += unidades[indice];
                    }
                }
                divisor /= 10;
            }
            return extenso;
        }
    }
}