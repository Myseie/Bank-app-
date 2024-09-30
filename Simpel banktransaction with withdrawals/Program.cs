using Simpel_banktransaction_with_withdrawals;

class Program
{
    static void Main()
    {
        BankManager manager = new BankManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nVälj ett alternativ.");
            Console.WriteLine("1.Skapa konto");
            Console.WriteLine("2.Sätt in pengar");
            Console.WriteLine("3.Ta ut pengar");
            Console.WriteLine("4.Visa kontoutdrag");
            Console.WriteLine("5.Avsluta");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange kontonummer:");
                    int accountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Ange startsaldo:");
                    decimal initialBalance = decimal.Parse(Console.ReadLine());

                    manager.CreateAccount(accountNumber, initialBalance);
                    break;
                case "2":
                    Console.Write("Ange kontonummer:");
                    accountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Ange belopp att sätta in:");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());

                    manager.DepositToAccount(accountNumber, depositAmount);
                    break;
                case "3":
                    Console.Write("Ange kontonummer:");
                    accountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Ange belopp att ta ut:");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                    manager.WithdrawFromAccount(accountNumber, withdrawAmount);
                    break;
                case "4":
                    Console.Write("Ange kontonummer:");
                    accountNumber = int.Parse(Console.ReadLine());

                    manager.ShowAccountHistory(accountNumber);
                    break;
                case "5":
                    exit = true;
                    break;


                default:
                    Console.WriteLine("Ogiltligt val, försök igen");
                    break;
            }
        }
    }
}