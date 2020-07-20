using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct User
    {
        public string name;
        public string location;
        int age;
        public User(string name, string location, int age)
        {
            this.name = name;
            this.location = location;
            this.age = age;

        }
        class Program
        {
            static void Main(string[] args)
            {
                User u = new ConsoleApplication1.User("raju","Uttarkhand", 32);
                Console.WriteLine("Name:{0}, Location:{1}, Age:{2}", u.name, u.location, u.age);
            }
        }
    }
}
