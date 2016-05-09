using AldrinWorkSample.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldrinWorkSample.Model.Repositories
{
    public class UserRolesRepository
    {
        private AldrinWorkSampleDbContext _db = null;

        public UserRolesRepository(AldrinWorkSampleDbContext db)
        {
            _db = db;
        }

        //public List<UserRolesView> GetAllRoles(string userName)
        //{
        //    return _db.UserRolesView.Where(u => u.UserName == userName).ToList<UserRolesView>();
        //}
    }
}
