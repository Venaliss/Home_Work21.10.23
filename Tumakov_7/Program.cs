using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_7
{
    class Bank
    {
        private long Balance { get; set;}
        private long Number { get; set;}
        private enum bank_account
        {
            actual_bank_account = 18102023,
            saving_bank_account = 21102023
        }
        
        private Bank(long balance, long number)
        {
            Balance = balance;
            Number = number;
        }
        static void Tumakov1()
        {
            bank_account account_bank = bank_account.actual_bank_account;
            Console.WriteLine("Счет в банке: {0}", (long)account_bank);
            bool flag1 = true;
            bool flag2 = true;
            while (flag1 & flag2)
            {
                Console.Write("Введите пожалуйста номер счета:");
                if (Int64.TryParse(Console.ReadLine(), out long number))
                {
                    
                    Console.WriteLine("Успешно");
                }
                else
                {
                    Console.WriteLine("Ошибка введеных данных");
                    flag1 = false;
                }
                Console.Write("Введите пожалуйста баланс счета:");
                if (Int64.TryParse(Console.ReadLine(), out long balance) & flag1)
                {
                    Console.WriteLine("Успешно");
                    flag2 = false;
                }
                else
                {
                    Console.WriteLine("Ошибка введеных данных");
                    flag1 = true;
                }
                Bank account = new Bank(number, balance);
                Console.WriteLine("Номер счета равен = {0}, Баланс счета равен = {1}", account.Balance, account.Number);
            }
            
        }
        static void Main()
        {
            Tumakov1();
            Console.ReadKey();
        }
    }
}
