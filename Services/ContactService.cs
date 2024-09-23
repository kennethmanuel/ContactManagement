using ContactManagement.Models;

namespace ContactManagement.Services;

public class ContactService : IContactService
{
    private readonly IntranetHomeContext dbContext;

    public ContactService(IntranetHomeContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task AddContactAsync(Contact contact)
    {
        dbContext.ContactManagemen.Add(contact);
        await dbContext.SaveChangesAsync();
    }
    public async Task UpdateContactAsync(Contact contact)
    {
        dbContext.ContactManagemen.Update(contact);
        await dbContext.SaveChangesAsync();
    }
    public async Task DeleteContactAsync(Contact contact)
    {
        dbContext.ContactManagemen.Remove(contact);
        await dbContext.SaveChangesAsync();
    }
}
