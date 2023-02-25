using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBaltaCarnaval
{
    public static class SetimoDia
    {
        public static void PiramideFibonacci()
        {
            Console.Clear();
            List<int> sequenciaFibonacci = new List<int>();
            string sequenciaFibonacciString = "";
            int proximoValor = 0;
            for (int i = 0; i <= 20; i++)
            {
                sequenciaFibonacci.Add(proximoValor);
                if (i > 0)
                {
                    proximoValor = sequenciaFibonacci[i] + sequenciaFibonacci[i-1];
                }
                else
                {
                    proximoValor = sequenciaFibonacci[i] + 1;
                }
                sequenciaFibonacciString += $"{sequenciaFibonacci[i]} ";
                Console.WriteLine(sequenciaFibonacciString);
            }
            Console.ReadKey();
        }
    }
}