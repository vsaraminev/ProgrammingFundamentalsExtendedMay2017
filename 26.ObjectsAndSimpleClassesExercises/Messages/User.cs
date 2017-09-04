using System;
using System.Collections.Generic;

namespace Messages
{
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
