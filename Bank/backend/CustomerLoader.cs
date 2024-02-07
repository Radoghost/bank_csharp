using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.backend
{
    public static class CustomerLoader
    {
        public static List<Customer> LoadCustomers()
        {
            var customers = new List<Customer>();
            var customer001 = new Customer(1, "Jan", "Nowak", "001", 1457.23m);
            customers.Add(customer001);
            var customer002 = new Customer(2, "Agnieszka", "Kowalska", "002", 3600.18m);
            customers.Add(customer002);
            var customer003 = new Customer(3, "Robert", "Lewandowski", "003", 2745.03m);
            customers.Add(customer003);
            var customer004 = new Customer(4, "Zofia", "Płucińska", "004", 7344.00m);
            customers.Add(customer004);
            var customer005 = new Customer(5, "Grzegorz", "Braun", "005", 455.38m);
            customers.Add(customer005);
            return customers;
        }
    }
}
