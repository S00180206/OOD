using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            nameQuery();

        }
        private static void nameQuery()
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };



            var outputNames = from name in names
                             // where name > 5
                              orderby name
                              select name;

            var query1 = names.where("{M}");

            foreach (string name in outputNames)
            {
                Console.WriteLine(name.ToString());
            }
            Console.ReadLine();
        }
        
        
        }
        Exercise9
        private static List<Customer> GetCustomers()
        {
            GetCustomers c1 = new GetCustomers { Name = "Tom", City = "Dublin" };
            GetCustomers c2 = new GetCustomers { Name = "Sally", City = "Galway" };
            GetCustomers c3 = new GetCustomers { Name = "George", City = "Cork" };
            GetCustomers c4 = new GetCustomers { Name = "Molly", City = "Dublin" };
            GetCustomers c5 = new GetCustomers { Name = "Joe", City = "Galway" };

            List<Customer>.Add(c1);
            List<Customer>.Add(c2);
            List<Customer>.Add(c3);
            List<Customer>.Add(c4);
            List<Customer>.Add(c5);

            return customers;
        }
    public class Customer
    {
        public string Name { get; set; }
        public long City { get; set; }
        

        public override string ToString()
        {
            return string.Format("{0,-30}{1:F0}", Name, City);
        }



        //       Exercise10
        //       List<Customer> customers = GetCustomers();
        //       var query = from cust in customers
        //                   where (cust.City == "Dublin" || cust.City == "Galway")
        //                   orderby cust.Name
        //                   select cust.Name;

        //       var query = customers
        //           .Where(c => c.City == "Dublin")
        //           .Select(c => c.Name);

        //       foreach (var name in query)
        //{
        //           Console.WriteLine(name);
        //}

    }
}
