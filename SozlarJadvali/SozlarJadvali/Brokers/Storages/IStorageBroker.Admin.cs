using SozlarJadvali.Models.Admins;

namespace SozlarJadvali.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Admin> InsertAdminAsync(Admin admin);
        IQueryable<Admin> SelectAllAdmins();
        ValueTask<Admin> SelectAdminByIdAsync(Guid id);
        ValueTask<Admin> UpdateAdminAsync(Admin admin);
        ValueTask<Admin> DeleteAdminAsync(Admin admin);
    }
}
