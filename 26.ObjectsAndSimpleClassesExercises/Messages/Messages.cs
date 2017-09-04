using System;
using System.Linq;
using System.Collections.Generic;

namespace Messages
{
    public class Messages
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var users = new Dictionary<string, User>();

            while (input != "exit")
            {
                var currentInput = input
                    .Split(' ');

                if (currentInput[0] == "register")
                {
                    var username = currentInput[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    var sender = currentInput[0];
                    var recipient = currentInput[2];
                    var content = currentInput[3];

                    if (users.ContainsKey(sender)
                        && users.ContainsKey(recipient))
                    {
                        User senderUser = users[sender];
                        users[recipient].Messages.Add(new Message(content, senderUser));
                    }
                }

                input = Console.ReadLine();
            }

            var chatInput = Console.ReadLine()
                .Split(' ');

            var chatSender = chatInput[0];
            var chatRecipient = chatInput[1];

            var senderMess = users[chatRecipient]
                .Messages
                .Where(m => m.Sender.UserName == chatSender)
                .ToList();

            var recipientMess = users[chatSender]
                .Messages
                .Where(m => m.Sender.UserName == chatRecipient)
                .ToList();

            if (senderMess.Count == 0 && recipientMess.Count == 0)
            {
                Console.WriteLine("No messages");
            }

            var index = 0;

            while (index < senderMess.Count && index < recipientMess.Count)
            {
                Console.WriteLine($"{chatSender}: {senderMess[index].Content}");
                Console.WriteLine($"{recipientMess[index].Content} :{chatRecipient}");
                index++;
            }

            while (index < senderMess.Count)
            {
                Console.WriteLine($"{chatSender}: {senderMess[index].Content}");
                index++;
            }
            while (index < recipientMess.Count)
            {
                Console.WriteLine($"{recipientMess[index].Content} :{chatRecipient}");
                index++;
            }
        }

        public class Message
        {
            public string Content { get; set; }

            public User Sender { get; set; }

            public Message(string content, User sender)
            {
                this.Content = content;
                this.Sender = sender;
            }
        }

        public class User
        {
            public string UserName { get; set; }

            public List<Message> Messages { get; set; }

            public User(string username)
            {
                this.UserName = username;
                this.Messages = new List<Message>();
            }
        }
    }
}
