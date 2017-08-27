using System.Collections.Generic;
using System.Linq;

namespace MediatorDesignPatternExample
{
    public class ChatRoom
    {
        private List<Participant> participants = new List<Participant>();

        public void Broadcast(string source, string message)
        {
            foreach (var p in participants)
                if (p.Name != source)
                    p.Receive(source, message);
        }

        public void Join(Participant p)
        {
            string joinMsg = $"{p.Name} joins the chat";
            Broadcast("room", joinMsg);

            p.Room = this;
            participants.Add(p);
        }

        public void Message(string source, string destination, string message)
        {
            participants.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
        }
    }
}