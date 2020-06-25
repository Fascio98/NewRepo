using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } // new table one to many
        public string Industry { get; set; }
        public string Logo { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
