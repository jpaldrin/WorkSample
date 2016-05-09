using AldrinWorkSample.Model;
using System.Security.Principal;
using System.Transactions;
using AldrinWorkSample.Model.Repositories;
using System;

namespace AldrinWorkSample.Repository.Common
{
    public class AldrinWorkSampleUnitOfWork : IAldrinWorkSampleUnitOfWork
    {
        private UnitOfWorkContext _uowContext;
        private AldrinWorkSampleDbContext _dbContext;
        private UserRolesRepository _userRolesRepository;


        public AldrinWorkSampleUnitOfWork(int? SAUId, IPrincipal user)
        {
            _uowContext = new UnitOfWorkContext(SAUId, user);
        }

        public AldrinWorkSampleUnitOfWork(UnitOfWorkContext context)
        {
            _uowContext = context;
        }

        public void Save()
        {

            using (TransactionScope ts = new TransactionScope())
            {
                _dbContext.SaveChanges();
            }
        }

        public UnitOfWorkContext Context
        {
            get { return _uowContext; }
        }

        public AldrinWorkSampleDbContext AldrinWorkSampleDB
        {
            get
            {
                return _dbContext ?? (_dbContext = new AldrinWorkSampleDbContext(_uowContext));
            }
        }

        public UserRolesRepository UserRolesRepository
        {
            get
            {
                return _userRolesRepository ?? (_userRolesRepository = new UserRolesRepository(AldrinWorkSampleDB));
            }
        }
    }
}
