using BLL.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTO.Manage
{
    public class PersonDTO
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; } // Enum
        [Display(Name = "Personal ID")]
        public string PersonID { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Organization Name")]
        public string OrganizationName { get; set; }
        public PositionEnum Position { get; set; } // Enum
    }
}
