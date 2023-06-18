using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Advertisement
    {
        public string Company { get; init; }

        public string Content { get; init; }

        public Advertisement(string company)
        {
            Company = company;
            Content = $"Some {company} add recommended for you!";
        }

        public override string ToString()
        {
            return $"Author:{Company}, Content:{Content}";
        }
    }
}
