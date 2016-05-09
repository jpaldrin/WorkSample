using AldrinWorkSample.Model;
using System.Security.Principal;


namespace AldrinWorkSample.Repository.Common
{
    public static class UnitOfWorkFactory
    {
        public static IAldrinWorkSampleUnitOfWork Create(int? SAUId, IPrincipal user)
        {
            return new AldrinWorkSampleUnitOfWork(SAUId, user);
        }
        public static IAldrinWorkSampleUnitOfWork Create(UnitOfWorkContext context)
        {
            return new AldrinWorkSampleUnitOfWork(context);
        }
    }
}
