using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._13._2019
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person newPerson = new Person();
            //Console.Write("Zehmet olmasa adinizi daxil edin:");
            //string ad=Console.ReadLine();
            //Console.Write("Zehmet olmasa emailinizi daxil edin:");
            //string email = Console.ReadLine();
            //int d = 0;

            //while (d==0)
            //{
            //    Console.Write("Zehmet olmasa yasinizi daxil edin:");
            //    string yas = Console.ReadLine();

            //    try
            //    {
            //       byte yeniyas = Convert.ToByte(yas);
            //        d = 5;
            //        newPerson.deyerotur(ad, email, yeniyas);
            //        Console.WriteLine(newPerson.name + " " + newPerson.email + " " + newPerson.age);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("------------------------------------");
            //        Console.WriteLine("Zehmet olmasa duzgun yas daxil edin");
            //        Console.WriteLine("------------------------------------");

            //    }
            //}
            
            //**Value** 
            //int a = 8;
            //int b = a;
            //Console.WriteLine(a+" "+b);
            //b = 5;
            //Console.WriteLine(a + " " + b);
            //Console.WriteLine("------------------------");


            //** References type**
            //int[] array1 = { 1, 5, 78, 53, 2,45 };
            //int[] arrayCopy = array1;
            //Console.WriteLine(array1[1] +" "+arrayCopy[1]);
            //arrayCopy[1] = 15;
            //Console.WriteLine(array1[1] + " " + arrayCopy[1]);

            //***********************
            //Objectler
            object a =45;
            int b = (int)a;
            Console.WriteLine(b);
        }
    }
    class Person
    {
        public string name;
        public string email;
        public byte age;
        public void deyerotur(string name,string email,byte age)
        {
            this.name = name;
            this.email = email;
            this.age = age;
        }
    }
}
