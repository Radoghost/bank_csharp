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
            var customer001 = new Customer(1, "Jan", "Nowak", "001", 1457.23);
            customers.Add(customer001);
            var customer002 = new Customer(2, "Agnieszka", "Kowalska", "002", 3600.18);
            customers.Add(customer002);
            var customer003 = new Customer(3, "Robert", "Lewandowski", "003", 2745.03);
            customers.Add(customer003);
            var customer004 = new Customer(4, "Zofia", "Płucińska", "004", 7344.00);
            customers.Add(customer004);
            var customer005 = new Customer(5, "Grzegorz", "Braun", "005", 455.38);
            customers.Add(customer005);
            return customers;
        }
    }
}
