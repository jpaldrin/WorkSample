using System;
using System.Collections.Generic;


namespace AldrinWorkSample.Model.Models
{
    public partial class UserRolesView
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ModuleId { get; set; }
        public int RoleId { get; set; }
        public int OrganizationId { get; set; }
        public string RoleName { get; set; }
    }
}
