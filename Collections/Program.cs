using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           User admin = new User();
           User user = new User();
           User customer = new User();

           List<User> users = new List<User> { admin, user, customer};

            Console.WriteLine(users.Count);

            users.Clear();
            Console.WriteLine(users.Count);
        }
    }


    public class User
    {
        public string name;
        public int age;
        public User() { name = "Unknown"; age = 18; }
    }
}
