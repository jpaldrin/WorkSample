using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using AldrinWorkSample.Model.Common;
using System.Diagnostics;
using System.Linq;

namespace AldrinWorkSample.Model
{
    public partial class AldrinWorkSampleDbContext : DbContext
    {
        private UnitOfWorkContext _context;

        public UnitOfWorkContext Context
        {
            get
            {
                return _context;
            }
        }

        public AldrinWorkSampleDbContext(UnitOfWorkContext context)
        {
            _context = context;
        }

        private void UpdateModifiedAuditFields()
        {
            var changes = from e in this.ChangeTracker.Entries()
                          where e.State == System.Data.Entity.EntityState.Modified
                          && e.Entity is IAuditableEntity
                          select e.Entity as IAuditableEntity;

            foreach (var change in changes)
            {
                change.UpdatedBy = Context.User.Identity.Name;
                change.UpdatedDate = DateTime.Now;
            }
        }

        

        public void  UpdateCreatedAuditFields()
        {
            var additions = from e in this.ChangeTracker.Entries()
                            where e.State == System.Data.Entity.EntityState.Added
                            && e.Entity is IAuditableEntity
                            select e.Entity as IAuditableEntity;

            foreach (var addition in additions)
            {
                addition.CreatedBy = Context.User.Identity.Name;
                addition.CreatedDate = DateTime.Now;
                addition.UpdatedBy = addition.CreatedBy;
                addition.UpdatedDate = addition.CreatedDate;
            }
        }

        private void UpdateDeletedAuditFields()
        {
            var deleted = from e in this.ChangeTracker.Entries()
                          where e.State == System.Data.Entity.EntityState.Deleted
                          && e.Entity is IAuditChangesAndDeletion
                          select e.Entity as IAuditChangesAndDeletion;

            foreach (var delete in deleted)
            {
                delete.DeletedBy = Context.User.Identity.Name;
                delete.DeletedDate = delete.CreatedDate;
            }
        }

        public void Save()
        {
            this.SaveChanges();
        }

        public override int SaveChanges()
        {
            UpdateCreatedAuditFields();
            UpdateModifiedAuditFields();
            UpdateDeletedAuditFields();

            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}

