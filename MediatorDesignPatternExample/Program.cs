using System;
using static System.Console;

namespace MediatorDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom room = new ChatRoom();

            Participant john = new Person("John");
            Participant jane = new Person("Jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hi room");
            jane.Say("oh, hey john");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "glad you could join us!");
            //Read();
        }
    }
}