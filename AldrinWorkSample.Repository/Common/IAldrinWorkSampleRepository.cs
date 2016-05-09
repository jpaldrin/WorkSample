using AldrinWorkSample.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldrinWorkSample.Repository.Common
{
    public interface IAldrinWorkSampleRepository : IAldrinWorkSampleUnitOfWork
    {
        UserRolesRepository UserRolesRepository { get; }
    }
}
