using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.backend
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public Customer(int id, string name, string lastName, string accountNumber, decimal accountBalance)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }

        public void ShowCustomerInfo(Customer customer)
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine($"ID: {customer.Id}");
            Console.WriteLine($"IMIĘ I NAZWISKO: {customer.Name} {customer.LastName}");
            Console.WriteLine($"NR KONTA: {customer.AccountNumber}");
            Console.WriteLine($"SALDO: {Math.Round(customer.AccountBalance, 2)}");
        }
    }
}
