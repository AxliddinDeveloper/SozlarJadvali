using SozlarJadvali.Brokers.Storages;
using SozlarJadvali.Models.Admins;

namespace SozlarJadvali.Services.Admins
{
    public class AdminService : IAdminService
    {
        private readonly IStorageBroker storageBroker;

        public AdminService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Admin> AddAdminAsync(Admin admin) =>
            await this.storageBroker.InsertAdminAsync(admin);

        public async ValueTask<Admin> RetrieveAdminByIdAsync(Guid id) =>
            await this.storageBroker.SelectAdminByIdAsync(id);

        public IQueryable<Admin> RetrieveAllAdmins() =>
            this.storageBroker.SelectAllAdmins();

        public async ValueTask<Admin> ModifyAdminAsync(Admin admin) =>
            await this.storageBroker.UpdateAdminAsync(admin);

        public async ValueTask<Admin> RemoveAdminAsync(Admin admin) =>
            await this.storageBroker.DeleteAdminAsync(admin);
    }
}
