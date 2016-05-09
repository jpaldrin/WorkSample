using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using AldrinWorkSample.Model;

namespace AldrinWorkSample.Repository.Common
{
    public interface IAldrinWorkSampleUnitOfWork
    {
        UnitOfWorkContext Context { get; }

        void Save();
    }
}
