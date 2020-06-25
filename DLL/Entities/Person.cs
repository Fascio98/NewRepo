using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } // Enum
        public string PersonID { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Phone { get; set; } // new table one to many
        public string Picture { get; set; }
        public int OrganizationId { get; set; }
        public string Position { get; set; } // Enum

        public Organization Organization { get; set; }
    }
}
