using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_nambers_project_Dr.samier_Elmougy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startingNumber, endingNumbeer;
            Console.WriteLine("Get All Perfect In Range of Between two Number");
            Console.Write("Enter First Number : ");
            startingNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            endingNumbeer = int.Parse(Console.ReadLine());
            int max=Math.Max(startingNumber, endingNumbeer);
            int min=Math.Min(startingNumber, endingNumbeer);
            Console.WriteLine("Below are the perfect numbers between " + startingNumber + " and " + endingNumbeer);

            for (int i = min; i <= max; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine("\t" + i);
            }

            Console.ReadKey();

        }
    }
}
