using BLL.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO.Manage
{
    public class OrganizationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IndustryEnum Industry { get; set; }
        public string Logo { get; set; }
    }
}
