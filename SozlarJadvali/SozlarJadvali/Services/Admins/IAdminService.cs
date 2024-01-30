using SozlarJadvali.Models.Admins;

namespace SozlarJadvali.Services.Admins
{
    public interface IAdminService
    {
        ValueTask<Admin> AddAdminAsync(Admin admin);
        IQueryable<Admin> RetrieveAllAdmins();
        ValueTask<Admin> RetrieveAdminByIdAsync(Guid id);
        ValueTask<Admin> ModifyAdminAsync(Admin admin);
        ValueTask<Admin> RemoveAdminAsync(Admin admin);
    }
}
