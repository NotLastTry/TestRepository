using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Нагорнов_А.В._ЛР1
{
    internal class Program
    {
        class Person //Определение класса Person
        {
            public string name = "Ben";
            public int age = 18;
            public string email = "ben@gmail.com";
            public Person(string name) //Конструктор Person(string name)
            {
                this.name = name;
            }
            public Person(string name, int age) : this(name) //Конструктор Person(string name, int age) вызывает другой конструктор Person(string name) с параметром name
            {
                this.age = age;
            }
            public Person(string name, int age, string email) : this("Bob", age) //Конструктор Person(string name, int age, string email) вызывает другой конструктор Person(string name, int age) с параметрами "Bob", age
            {
                this.email = email;
            }
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
            Person P = new Person("Artyom", 25, "Artyom@gmail.com"); //Определение объекта P класса Person
            Message M = new Message(); //Определение объекта M класса Message
            Message M1 = new Message("Aboba"); //Определение объекта M1 класса Message
            M.Type();
            M1.Type();
        }
    }
}
