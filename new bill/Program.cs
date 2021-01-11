using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_bill

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of friend");
            int number = Int32.Parse(Console.ReadLine());

            int[] amount = new int[100];
            
            for(int i= 0; i<number;i++)
            {
                amount[i] = 0;
                
            }
            int j = 1;
            int perperson = 0;
            int totalExp = 0;
            int expenses = 0;
            while (j>0)
            {
                Console.WriteLine("Enter which frnd has paid");
                j = Int32.Parse(Console.ReadLine());

                Console.WriteLine("amt. Friend {0} has paid ", j);
                if (j > 0)
                {
                    expenses = Int32.Parse(Console.ReadLine());
                    amount[j - 1] += expenses;
                    totalExp += expenses;
                    perperson += expenses/ number;
                }
            }

            Console.WriteLine("total expense is {0}", totalExp);

            Console.WriteLine("total expense per person is {0}", perperson);

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Friend {0} pay {1} ", i+1, amount[i] - perperson);

            }
            Console.ReadLine();

        }
    }
}