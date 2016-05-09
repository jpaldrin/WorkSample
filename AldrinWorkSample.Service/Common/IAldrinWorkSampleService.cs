using System;
using System.Collections.Generic;
using AldrinWorkSample.Model.Models;
using AldrinWorkSample.Model;
using System.Text;
using System.Threading.Tasks;

namespace AldrinWorkSample.Service.Common
{
    public interface IAldrinWorkSampleService
    {
        List<UserRolesView> GetAllRoles(string username);
    }
}
