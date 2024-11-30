using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Нагорнов_А.В._ЛР1
{
    internal class Program
    {
        class Human
        {
<<<<<<< HEAD
            public string Name { get; set; }
=======
            private readonly string _id;        
            public string Id { get { return _id; } set { _id = Id; } }

            private string _name;
            public string Name { get { return _name; } set { _name = value; } }

            public void Print()
            {
                Console.WriteLine($"{Id}");
            }



>>>>>>> da8e82a (private string _name)
        }
        class Person : Human

        {
            private int _id;
            public string name = "Ben";
            public int age = 18;
            public string email = "ben@gmail.com";
            public Person(string name) 
            {
                this.name = name;
            }
            public Person(string name, int age) : this(name) 
            {
                this.age = age;
            }
            public Person(string name, int age, string email) : this("Bob", age) 
            {
                this.email = email;
            }
        }

        class Worker : Human 
        { 
        
        }

        class Message //Определение класса Message
        {
            public string message = "Hello, World!";

            public Message() 
            {   }

            public Message(string message)
            {
                this.message = message;
            }
            public void Type() //определение метода Type
            {
                Console.WriteLine(message);
                
            }
        }
        static void Main(string[] args)
        {
            Person P = new Person("Artyom", 25, "Artyom@gmail.com"); 
            Message M = new Message(); //Определение объекта M класса Message
            Message M1 = new Message("Aboba"); //Определение объекта M1 класса Message
            M.Type();
            M1.Type();
        }
    }
}
