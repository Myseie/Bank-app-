using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_banktransaction_with_withdrawals
{
    class BankManager
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void CreateAccount(int accountNumber, decimal initialBalance)
        {
            BankAccount newAccount = new BankAccount(accountNumber, initialBalance);
            accounts.Add(newAccount);
            Console.WriteLine($"Konto med nummer {accountNumber} har skapats.");
        }

        private BankAccount FindAccount(int accountNumber)
        {
            return accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

        }

        public void DepositToAccount(int accountNumber, decimal amount)
        {
            BankAccount account = FindAccount(accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Kontot hittades inte");
            }

        }

        public void WithdrawFromAccount(int accountNumber, decimal amount)
        {
            BankAccount account = FindAccount(accountNumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Kontot hittades inte");
            }
        }

        public void ShowAccountHistory(int accountNumber)
        {
            BankAccount account = FindAccount(accountNumber);
            if (account != null)
            {
                account.ShowTransactionHistory();
            }
            else
            {
                Console.WriteLine("Kontot hittades inte");
            }

        }
    }
}
