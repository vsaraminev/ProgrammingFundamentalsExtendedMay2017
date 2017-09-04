using System;
using System.Linq;
using System.Collections.Generic;

namespace WebSites
{
    public class WebSites
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var webList = new List<WebSite>();

            while (input != "end")
            {
                var currentInput = input
                    .Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var currentSite = new WebSite()
                {
                    Host = currentInput[0],
                    Domain = currentInput[1],
                    Queries = currentInput.Skip(2).ToList()
                };

                webList.Add(currentSite);

                input = Console.ReadLine();
            }

            foreach (var web in webList)
            {
                if (web.Queries.Count != 0)
                {
                    Console.Write($"https://www.{web.Host}.{web.Domain}/query?=");
                    Console.WriteLine($"[{string.Join("]&[", web.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{web.Host}.{web.Domain}");
                }
            }
        }

        public class WebSite
        {
            public string Host { get; set; }

            public string Domain { get; set; }

            public List<string> Queries { get; set; }
        }
    }
}
