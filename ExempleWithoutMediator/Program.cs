using System;
using System.Collections.Generic;
using ExempleWithoutMediator;

namespace ExempleWithoutMediator
{
    class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {

            var john = new Person("John");
            var jane = new Person("Jane");
            var jason = new Person("Jason");
            people.Add(john);
            people.Add(jane);
            people.Add(jason);

            john.Say("Hi folks", people);
            jane.Say("Hi guys", people);

            jason.PrivateMessage(jane, "do u know who is john?");
            jane.PrivateMessage(john, "glad you could join us!");
        }
    }
}