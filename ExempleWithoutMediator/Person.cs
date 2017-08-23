using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ExempleWithoutMediator
{
    public class Person
    {
        public string Name;
        private List<string> chatLog = new List<string>();

        public Person(string name)
        {
            Name = name;
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            WriteLine($"[{Name}'s chat session] {s}");
            chatLog.Add(s);
        }

        public void Say(string message, List<Person> persons)
        {
            foreach(var p in persons)
            {
                if(p != this)
                    p.Receive(this.Name, message);
            }
        }

        public void PrivateMessage(Person destination, string message)
        {
            destination.Receive(this.Name, message);
        }
    }
}
