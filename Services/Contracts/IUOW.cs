using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IUOW : IDisposable
    {
        public IOrganizationRepository Organization { get; }
        public IPersonRepository Person { get; }
        void Commit();
    }
}
