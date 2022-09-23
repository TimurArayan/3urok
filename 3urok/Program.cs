using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _17._09._2022
{
    enum BankTypes
    {
        Current,
        Save
    }
    //--------------------------------------------------------------------------------------
    struct Bank
    {
        public int number;
        public string type;
        public int balance;

        public Bank(int number, string type, int balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
        }
    }
    //----------------------------------------------------------------------------------------------------------------
    enum Universities
    {
        KGU,
        KAI,
        KHTI
    }

    struct Worker
    {
        public string name;
        public object VUZ;

        public Worker(string name, object VUZ)
        {
            this.name = name;
            this.VUZ = VUZ;
        }
        public void Print2()
        {
            Console.WriteLine($"Имя: {name}, Вуз: {VUZ}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            BankTypes now = BankTypes.Save;
            Console.WriteLine("Тип - {0}, номер - {1}", now, (int)now);

            Console.WriteLine("Задание 3.2");
            Bank bank = new Bank();
            bank.number = 10;
            bank.type = "Петя";
            bank.balance = 100;
            bank.Print();

            Console.WriteLine("Задание 3.3");
            Worker worker = new Worker();
            worker.name = "Илья";
            worker.VUZ = (object)Universities.KGU;
            worker.Print2();

        }
    }
}
