using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba7Vlad
{
    class Program
    {
        public static double[] Function(double[] array)
        {
            double[] result = new double[array.Length + 2];
            double firstNegativNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && firstNegativNum == 0)
                {
                    firstNegativNum = array[i];
                    break;
                }
            }

            double num = 0;
            if (array.Length >= 49)
            {
                num = firstNegativNum + array[49];
            }
            else
            {
                num = firstNegativNum;
            }


            double avg = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] / num;
                sum += result[i];
            }

            result[result.Length - 2] = sum;
            result[result.Length - 1] = sum / result.Length;

            return result;
        }

        static void Main(string[] args)
        {
            double[] array = new double[100];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\n\n\n");

            array = Function(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString("00.00") + " | ");
            }

            Console.WriteLine();
        }
    }
}
