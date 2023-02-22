using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class SegundoDia
    {
        public static void CalcularIMC()
        {
            Console.Write("Digite o peso: ");
            double.TryParse(Console.ReadLine(), out double peso);
            Console.Write("Digite a altura: ");
            double.TryParse(Console.ReadLine(), out double altura);
            if (peso > 0 && altura > 0)
            {
                double Imc = peso / Math.Pow(altura, 2);
                Console.WriteLine($"Seu IMC é: {Imc.ToString("N2")}");
                if (Imc >= 25 && Imc <= 29.9)
                {
                    Console.WriteLine($"Sobrepeso");
                    Console.WriteLine($"Risco: Aumentado");
                }
                else if(Imc >= 30 && Imc <= 34.9){
                    Console.WriteLine($"Obesidade Grau I");
                    Console.WriteLine($"Risco: Moderado");
                }
                else if(Imc >= 35 && Imc <= 40){
                    Console.WriteLine($"Obesidade Grau II");
                    Console.WriteLine($"Risco: Grave");
                }
                else if(Imc > 40)
                {
                    Console.WriteLine($"Obesidade Grau III");
                    Console.WriteLine($"Risco: Muito Grave");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite peso e altura válidos.");
                Console.ReadKey();
            }
        }
    }
}