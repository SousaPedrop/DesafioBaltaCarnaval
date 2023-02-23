using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class QuartoDia
    {
        public static void PassarTroco()
        {
            Console.WriteLine("Digite o valor da compra: ");
            double.TryParse(Console.ReadLine(), out double precoCompra);
            Console.WriteLine("Digite o valor pago: ");
            double.TryParse(Console.ReadLine(), out double valorPago);
            if (valorPago >= precoCompra)
            {
                string trocoString = "";
                double troco = valorPago - precoCompra;
                double[] NotasEMoedas = { 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.10, 0.05 };
                Console.WriteLine();
                Console.WriteLine($"Valor da compra: R${precoCompra.ToString("N2")}");
                Console.WriteLine($"Valor pago: R${valorPago.ToString("N2")}");
                Console.WriteLine($"Valor do troco: R${troco.ToString("N2")}");
                while (troco > 0.05)
                {
                    int numeroDeNotas;
                    foreach (double valor in NotasEMoedas)
                    {
                        if (valor <= troco)
                        {
                            numeroDeNotas = (int)(troco / valor);
                            troco = troco - (numeroDeNotas * valor);
                            trocoString += $"\t- {numeroDeNotas} notas/moedas de R$ {valor.ToString("N2")}.\n";
                        }
                    }
                }
                Console.WriteLine(trocoString);
            }
            else
            {
                Console.WriteLine("Valor de pagamento insuficiente.");
            }
            Console.ReadKey();
        }
    }
}