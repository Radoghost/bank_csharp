using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.backend;

internal class Bank
{
    public List<Customer> Customers { get; set; } = CustomerLoader.LoadCustomers();


    public void ShowCustomers()
    {
        Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
        foreach (var customer in Customers)
        {
            Console.WriteLine($"{customer.Id} | {customer.Name} {customer.LastName} | {customer.AccountNumber} | {Math.Round(customer.AccountBalance, 2)} zł");
        }
        Console.WriteLine("\n");
    }

    public Customer LogIn()
    {
        Console.Clear();
        Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA: ");
        int userIdChoice;
        bool canParse = int.TryParse(Console.ReadLine(), out userIdChoice);

        var loggedCustomer = Customers.Find(x => x.Id == userIdChoice);
        Console.Clear();
            if (loggedCustomer == null) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LOGOWANIE NIEUDANE");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                loggedCustomer.ShowCustomerInfo(loggedCustomer);
            }
        return loggedCustomer;
    }
  


    public Customer getAccountToTransfer(Customer currentlyLoggedCustomer)
    {
        Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW: ");
        var userInput = Console.ReadLine();
        var accountToTransfer = Customers.Find(x => x.AccountNumber == userInput);
        Console.Clear();
        if (accountToTransfer is null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (accountToTransfer.AccountNumber == currentlyLoggedCustomer.AccountNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIE MOŻESZ ZROBIĆ PRZELEWU NA WŁASNE KONTO");
            Console.ForegroundColor = ConsoleColor.White;
        }
        return accountToTransfer;
        
 

    }

    public void makeMoneyTransfer(Customer loggedCustomer, Customer transferTo)
    {
        Console.Clear();
        Console.WriteLine("PODAJ KWOTĘ PRZELEWU: ");
        decimal amountToTransfer;
        bool canParse = decimal.TryParse(Console.ReadLine(), out amountToTransfer);
        Console.Clear();
        if (amountToTransfer > 0 && amountToTransfer <= loggedCustomer.AccountBalance)
        {
            loggedCustomer.AccountBalance -= amountToTransfer;
            transferTo.AccountBalance += amountToTransfer;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PRZELEW ZOSTAŁ WYKONANY");
            Console.ForegroundColor = ConsoleColor.White;
            ShowCustomers();
        } else if (!canParse || amountToTransfer <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWA KWOTA");
            Console.ForegroundColor = ConsoleColor.White;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
}
