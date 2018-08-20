using System;
using EF.Model;
using EF.Repositories;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATABASE");
            //Bank bank = new Bank("S-Pankki", "SBANFIHH");
            //BankRepository.Create(bank);

            var banks = BankRepository.Get();
            foreach (var b in banks)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }

       
    }
}
