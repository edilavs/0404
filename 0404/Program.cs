using System;
using Task_2;

namespace _0404
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            string groupNo;
            byte age;
            do
            {
                Console.WriteLine("Telebenin ad ve soyadini daxil edin: ");
                fullName = Console.ReadLine();
                Console.WriteLine("Telebenin qrupunu daxil edin: ");
                groupNo = Console.ReadLine();
                Console.WriteLine("Telebenin yasini daxil edin: ");
                age = Convert.ToByte(Console.ReadLine());
            } while (!groupNo.CheckGroupNo());
        }
    }
}
