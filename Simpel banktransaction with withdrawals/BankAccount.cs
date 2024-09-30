using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_banktransaction_with_withdrawals
{
    class BankAccount
    {
        public int AccountNumber { get; }

        public decimal Balance { get; private set; }

        private List<string> transactionHistory = new List<string>();

        public BankAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;

            Balance = initialBalance;

            transactionHistory.Add($"Konto har öppnat med saldo '{initialBalance:C}'");
        }

        public void Deposit (decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                transactionHistory.Add($"Insättning : {amount:C}");

            }
            else
            {
                Console.WriteLine("Beloppet måste vara större än 0");
            }

        }

        public void Withdraw(decimal amount)
        {
            if(amount > 0 && amount <= Balance)
            {
                Balance -= amount;

                transactionHistory.Add($"Uttag : {amount:C}");

            }
            else if (amount > Balance)
            {
                Console.WriteLine("Otllräckligt saldo.");
            }
            else
            {
                Console.WriteLine("Beloppet måste vara större än 0");

            }

        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine($"Kontoutdrag för konto {AccountNumber}:");
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);

            }
            Console.WriteLine($"Nuvarande saldo : {Balance:C}");
        }
    }
}
