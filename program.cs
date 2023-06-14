using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aritmetica_24_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[10];
            double va;
            int quan = 0;

            for (int i = 0; i < 10; i++) 
            {
                Console.Write($"Digite o {i}° número:");
                nums[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();

            va = (nums[1] + nums[2] + nums[3] + nums[4] + nums[5] + nums[6] + nums[7] + nums[8] + nums[9] + nums[0])/10;
            Console.WriteLine($"A média aritmética dos valores resultou: {va}");

            for(int i = 0 ; i < 10; i++)
            {
                if(nums[i] > va )
                {
                    quan++;
                }
            }
            Console.WriteLine($"Desses 10 N°, {quan} são maiores que a média.");
        }
    }
}
