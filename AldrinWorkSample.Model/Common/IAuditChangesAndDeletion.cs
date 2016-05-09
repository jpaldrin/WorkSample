using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldrinWorkSample.Model.Common
{
    public interface IAuditChangesAndDeletion : IAuditableEntity
    {
        string DeletedBy { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
