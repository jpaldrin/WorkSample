using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AldrinWorkSample.Model;

namespace AldrinWorkSample.Model.Repositories
{
    class ApplicationUserRepository
    {
        private AldrinWorkSampleDbContext _db = null;

        public ApplicationUserRepository(AldrinWorkSampleDbContext db)
        {
            _db = db;
        }
        //public ApplicationUserManager GetUser(string username)
        //{
        //    return _db.SF_UserAccountView.Where(u => u.UserName == username).FirstOrDefault();
        //}
    }
}
