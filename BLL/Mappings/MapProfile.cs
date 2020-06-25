using AutoMapper;
using BLL.DTO.Manage;
using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Person, PersonDTO>();

            CreateMap<Organization, OrganizationDTO>();
        }
    }
}
