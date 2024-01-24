using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.backend
{
    internal class Manager
    {

        public Manager()
        {
            
        }

        public void ShowOptions()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            Console.WriteLine("");
        }

        public void Build(Bank bank)
        {
            ShowOptions();
            int userChoice;
            bool canParse = int.TryParse(Console.ReadLine(), out userChoice);
            
            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    bank.ShowCustomers();
                    ShowOptions();
                    Build(bank);
                    break;
                case 2:
                    var currentlyLoggedCustomer = bank.LogIn();
                    var accoutToTransfer = bank.getAccountToTransfer(currentlyLoggedCustomer);
                    bank.makeMoneyTransfer(currentlyLoggedCustomer, accoutToTransfer);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    ShowOptions();
                    Build(bank);
                    break;
            }
        }
    }
}
