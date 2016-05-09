using System;
using System.Security.Principal;

namespace AldrinWorkSample.Model
{
    public class UnitOfWorkContext
    {
        private int? sAUId;

        public UnitOfWorkContext(int? sAUId, IPrincipal user)
        {
            this.sAUId = sAUId;
            User = user;
        }

        public int? CurrentOrganizationId { get; set; }
        public IPrincipal User { get; set; }
    }
}
