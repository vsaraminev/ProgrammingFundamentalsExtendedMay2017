using System;

namespace Messages
{
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
}
