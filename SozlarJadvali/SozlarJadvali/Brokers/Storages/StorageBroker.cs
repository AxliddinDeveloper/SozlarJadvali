using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace SozlarJadvali.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public StorageBroker()
        {
            this.Database.EnsureCreated();
        }

        public async ValueTask<T> InsertAsync<T>(T @object)
        {
            try
            {
                var broker = new StorageBroker();
                broker.Entry(@object).State = EntityState.Added;
                await broker.SaveChangesAsync();

                return @object;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<T> SelectAll<T>() where T : class
        {
            var broker = new StorageBroker();

            return broker.Set<T>();
        }

        public async ValueTask<T> SelectAsync<T>(params object[] objectsId) where T : class
        {
            var broker = new StorageBroker();

            return await broker.FindAsync<T>(objectsId);
        }

        public async ValueTask<T> UpdateAsync<T>(T @object)
        {

            var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Modified;
            await broker.SaveChangesAsync();

            return @object;
        }

        public async ValueTask<T> DeleteAsync<T>(T @object)
        {
            try
            {
                var broker = new StorageBroker();
                broker.Entry(@object).State = EntityState.Deleted;
                await broker.SaveChangesAsync();

                return @object;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source = SozlarJadvali.db";
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(connectionString);
        }

        public override void Dispose() { }
    }
}
