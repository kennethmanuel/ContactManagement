using ContactManagement.Models;

namespace ContactManagement.Services;

public interface IContactService
{
    Task AddContactAsync(Contact contact);
    Task UpdateContactAsync(Contact contact);
    Task DeleteContactAsync(Contact contact);
}
