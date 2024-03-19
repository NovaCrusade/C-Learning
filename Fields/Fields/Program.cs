using System.Collections.Generic;

namespace Csharpfund
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = new List<Order>();

        public Customer(int id) 
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {

        }
    }

    public class Order
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}