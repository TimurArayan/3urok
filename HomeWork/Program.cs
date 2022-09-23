using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    struct students
    {
        public string surname;
        public string name;
        public int id;
        public string birth;
        public string category;
        public int V;
        public students(string surname, string name, int id, string birth, string category, int V)
        {
            this.surname = surname;
            this.name = name;
            this.id = id;
            this.birth = birth;
            this.category = category;
            this.V = V;
        }
        public void Print1()
        {
            Console.Write($"{surname} {name} {birth}, категория {category}, выпил {V} л, ");
        }
    }
    struct User
    {
        public string name;
        public string town;
        public int age;
        public int pin;
        public User(string name, string town, int age, int pin)
        {
            this.name = name;
            this.town = town;
            this.age = age;
            this.pin = pin;
        }
        public void Print3()
        {
            Console.WriteLine(name + " " + town + " " + age + " " + pin);
        }
    }

    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            students student1 = new students("Иванов", "Иван", 1, "01.01.2001", "a", 5);
            students student2 = new students("Михайлов", "Михаил", 2, "02.02.2002", "b", 4);
            students student3 = new students("Дмитриев", "Дмитрий", 3, "03.03.2003", "с", 3);
            students student4 = new students("Семенров", "Семен", 4, "04.04.2004", "с", 2);
            students student5 = new students("Николаев", "Николай", 5, "05.05.2005", "d", 0);
            int summa = student1.V + student2.V + student3.V + student4.V + student5.V;
            student1.Print1();
            Console.WriteLine(student1.V * 100 / summa + "%");
            student2.Print1();
            Console.WriteLine(student2.V * 100 / summa + "%");
            student3.Print1();
            Console.WriteLine(student3.V * 100 / summa + "%");
            student4.Print1();
            Console.WriteLine(student4.V * 100 / summa + "%");
            student5.Print1();
            Console.WriteLine(student5.V * 100 / summa + "%");

            Console.WriteLine("Задача 2");
            Console.WriteLine("byte: " + byte.MaxValue + " " + byte.MinValue);
            Console.WriteLine("sbyte: " + sbyte.MaxValue + " " + sbyte.MinValue);
            Console.WriteLine("short: " + short.MaxValue + " " + short.MinValue);
            Console.WriteLine("ushort: " + ushort.MaxValue + " " + ushort.MinValue);
            Console.WriteLine("int: " + int.MaxValue + " " + int.MinValue);
            Console.WriteLine("uint: " + uint.MaxValue + " " + uint.MinValue);
            Console.WriteLine("int: " + int.MaxValue + " " + int.MinValue);
            Console.WriteLine("long: " + long.MaxValue + " " + long.MinValue);
            Console.WriteLine("ulong: " + ulong.MaxValue + " " + ulong.MinValue);
            Console.WriteLine("float: " + float.MaxValue + " " + float.MinValue);
            Console.WriteLine("double: " + double.MaxValue + " " + double.MinValue);
            Console.WriteLine("decimal: " + decimal.MaxValue + " " + decimal.MinValue);
            Console.WriteLine("bool: True(1) False(0)");
            Console.WriteLine("char: " + '\u0000' + " " + '\uffff');
            Console.WriteLine("string: зависит от памяти");

            Console.WriteLine("Задача 3");
            User user = new User();
            Console.Write("Введите имя: ");
            user.name = Console.ReadLine();
            Console.Write("Введите город: ");
            user.town = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user.age = int.Parse(Console.ReadLine());
            Console.Write("Введите пинкод: ");
            user.pin = int.Parse(Console.ReadLine());
            user.Print3();

            Console.WriteLine("Задача 4");
            Console.Write("ВВедите имя и фамилию через пробел: ");
            string names = Console.ReadLine();
            string name1 = names.Split(' ')[0];
            string name2 = names.Split(' ')[1];
            string n1 = name1[0].ToString();
            string n2 = name2[0].ToString();
            string x1 = n1.ToUpper();
            string x2 = n2.ToUpper();
            Console.WriteLine(x1 + "." + x2);

            Console.WriteLine("Задача 5");
            Console.Write("ВВедите стандартную цену: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("ВВедите скидку в %: ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("ВВедите цену отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            int z = 0;
            int raznitsa = 0;
            while (raznitsa < holidayPrice)
            {
                raznitsa = raznitsa + (normPrice * salePrice / 100);
                z++;
            }
            Console.WriteLine(z);

            Console.WriteLine("Задача 6");
            Console.Write("Введите скорость в км/ч: ");
            double speed1 = double.Parse(Console.ReadLine());
            double speed2 = speed1 * 10000 / 3600;
            double speed3 = Math.Floor(speed2);
            Console.WriteLine("Cкорость в cм/сек = " + speed3);

            Console.WriteLine("Задача 7");
            Console.Write("Введите строку: ");
            string stroka1 = Console.ReadLine();
            int q = stroka1.Length;
            string stroka2 = "";
            for (int i = 0; i < q; i++)
            {
                if (Char.IsLower(stroka1[i]) == true)
                {
                    stroka2 += stroka1[i].ToString().ToUpper();
                }
                else
                {
                    stroka2 += stroka1[i].ToString().ToLower();
                }
            }
            Console.WriteLine(stroka2);

        }

    }
}
}
