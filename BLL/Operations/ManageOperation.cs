using AutoMapper;
using BLL.DTO.Manage;
using BLL.Interfaces;
using BLL.Mappings;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{
    public class ManageOperation : IManageOperation
    {
        private readonly IUOW _service;
        private readonly IMapper _map;

        public ManageOperation(IUOW service, IMapper map)
        {
            _service = service;
            _map = map;
        }

        public IEnumerable<PersonDTO> GetAllPeople()
        {
            var people = _service.Person.GetAll();
            return _map.Map<IEnumerable<PersonDTO>>(people);
        }
    }
}
