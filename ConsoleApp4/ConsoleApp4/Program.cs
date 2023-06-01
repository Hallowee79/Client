using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Владимир", "Полупан", "Максимович", 20, "cxzc1113@gmail.com","89674563224");
            client.Print();
        }

    }
    class Client
    {
        private string FirsName;
        private string LastName;
        private string Patronymic;
        private int Age;
        private string email;
        private string phone;

        public string Firsname
        {
            get { return FirsName; }
            set { FirsName = value; }
        }
        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string patronymic
        {
            get { return Patronymic; }
            set { Patronymic = value; }
        }
        private int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone;}
            set { phone = value;}
        }
        public Client(string FirstName, string LastName, string Patronymic, int Age, string email, string phone)
        {
            this.FirsName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.Age = Age;
            this.email = email;
            this.phone = phone;
            

        }
        public void Print()
        {
            Console.WriteLine("Имя:" + FirsName);
            Console.WriteLine("Фамилия:" + LastName);
            Console.WriteLine("Отчество:" + Patronymic);
            Console.WriteLine("Возраст:" + Age);
            Console.WriteLine("Почта:" + Email);
            Console.WriteLine("Телефон:" + Phone);
        }
    }
}
