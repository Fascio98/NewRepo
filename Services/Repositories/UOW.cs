using DLL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public sealed class UOW : IUOW
    {
        private readonly OC_Context _context;
        private IOrganizationRepository _organizationRepository;
        private IPersonRepository _personRepository;

        public UOW(OC_Context context)
        {
            _context = context;
        }

        public IOrganizationRepository Organization
        {
            get
            {
                if (_organizationRepository == null)
                    _organizationRepository = new OrganizationRepository(_context);
                return _organizationRepository;
            }
        }

        public IPersonRepository Person
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository(_context);
                return _personRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
