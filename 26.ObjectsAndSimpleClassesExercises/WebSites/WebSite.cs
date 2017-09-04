using System;
using System.Collections.Generic;

namespace WebSites
{
    public class WebSite
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }
}
