using System;

namespace ChatExampleWithMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");
            Participant Myron = new Participant("Myron");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            chatroom.Register(Myron);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Myron", "My sweet love");

            // Wait for user
            Console.ReadKey();
        }
    }
}