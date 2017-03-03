namespace Gallery.Data
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Domain;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Data.Entity.Validation;

    public class GalleryContext : DbContext, IUnitOfWork
    {
        #region Constants
        private const string schema = "dbo";
        private const string connectionName = "name=DefaultConnection";

        
        #endregion

        #region Constructor
        public GalleryContext() : base(connectionName)
        {
            Database.SetInitializer<GalleryContext>(null);
            Database.Initialize(false);

            var x = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }
        #endregion

        #region Overrides
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }
            modelBuilder.Configurations.Add(new Configurations.CollectionConfiguration());
            modelBuilder.Configurations.Add(new Configurations.PaintingConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region IUnitOfWork members
        public DbSet<TEntity> GetSet<TEntity>() where TEntity : Entity
        {
            DbSet<TEntity> result = null;
            try
            {
                result = Set<TEntity>();
            }
            catch
            {
                throw;
            }
            return result;
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task CommitAsync()
        {
            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IUnitOfWork UnitOfWork
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
