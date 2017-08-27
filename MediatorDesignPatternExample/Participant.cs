using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace MediatorDesignPatternExample
{
    public abstract class Participant
    {
        public string Name;
        public ChatRoom Room;
        private List<string> chatLog = new List<string>();

        public Participant(string name)
        {
            Name = name;
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            WriteLine($"[{Name}'s chat session] {s}");
            chatLog.Add(s);
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }
    }
}
