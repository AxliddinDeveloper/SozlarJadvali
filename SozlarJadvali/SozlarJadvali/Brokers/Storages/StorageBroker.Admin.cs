using Microsoft.EntityFrameworkCore;
using SozlarJadvali.Models.Admins;

namespace SozlarJadvali.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Admin> Admins { get; set; }

        public async ValueTask<Admin> InsertAdminAsync(Admin admin) =>
            await InsertAsync(admin);

        public IQueryable<Admin> SelectAllAdmins() =>
            SelectAll<Admin>().AsQueryable();

        public async ValueTask<Admin> SelectAdminByIdAsync(Guid id) =>
            await SelectAsync<Admin>(id);

        public async ValueTask<Admin> UpdateAdminAsync(Admin admin) =>
            await UpdateAsync(admin);

        public async ValueTask<Admin> DeleteAdminAsync(Admin admin) =>
            await DeleteAsync(admin);
    }
}