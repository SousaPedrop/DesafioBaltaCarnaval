using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class TerceiroDia
    {
        public static void EscolherGasolinaOuAlcool()
        {
            Console.Write("Digite o valor do Alcool/Etanol: ");
            double.TryParse(Console.ReadLine(), out double PrecoEtanol);
            Console.Write("Digite o valor da Gasolina: ");
            double.TryParse(Console.ReadLine(), out double PrecoGasolina);
            if(PrecoEtanol > 0 && PrecoGasolina > 0) 
            {
                double comparacao = PrecoEtanol / PrecoGasolina;
                if (comparacao > 0.65)
                {
                    Console.WriteLine("É mais vantajoso abastercer com Alcool/Etanol.");
                }
                else
                {
                    Console.WriteLine("É mais vantajoso abastercer com Gasolina."); 
                }
            }
            Console.ReadKey();
        }
    }
}