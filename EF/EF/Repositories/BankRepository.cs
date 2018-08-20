using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Model;
using Microsoft.EntityFrameworkCore;

namespace EF.Repositories
{
    class BankRepository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
        }

        public static List<Bank> Get()
        {
            List<Bank> banks = _context.Bank.ToListAsync().Result;
            return banks;
        }

        public static Bank GetBankById(int id)
        {
            var bank = _context.Bank.FirstOrDefault(b => b.Id == id);
            return bank;
        }

        public static void Update(int id, Bank bank)
        {
            var updateBank = GetBankById(id);
            if (updateBank != null)
            {
                _context.Bank.Update(bank);
            }
            _context.SaveChanges();
        }

        public static void Delete(int id)
        {
            var delBank = _context.Bank.FirstOrDefault(b => b.Id == id);
            if (delBank != null)
                _context.Bank.Remove(delBank);
            _context.SaveChanges();
        }
    }
}
