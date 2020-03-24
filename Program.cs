using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1
{
    class Program
    {
        static void Main(string[] args)
        {

            // array length
            Console.WriteLine("Enter the array length: ");

            int length = Convert.ToInt32(Console.ReadLine());

            // number to multiply 
            Console.WriteLine("Enter the multiply number: ");
           int mul = Convert.ToInt32(Console.ReadLine());

            // initialize array
            int[] arr = new int[length];

            Console.WriteLine($"Array length is: {length}, num to mul is: {mul}");

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = i * mul;
                Console.Write(arr[i] + ", ");
            }

            Console.ReadKey();


        }
    }
}
