using System.Data;
using ContactManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Services;

public class ContactService : IContactService
{
    private readonly IDbContextFactory<IntranetHomeContext> _dbContextFactory;

    public ContactService(IDbContextFactory<IntranetHomeContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    public async Task<List<Contact>> GetContactsAsync()
    {
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.ContactManagemen.ToListAsync();
        }
        catch (Exception ex)
        {
            return [];
            throw new ApplicationException($"Unresolved application problem when getting a list of contact to database: {ex.Message}", ex);
        }
    }
    public async Task AddContactAsync(Contact contact)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        dbContext.ContactManagemen.Add(contact);
        await dbContext.SaveChangesAsync();
    }
    public async Task UpdateContactAsync(Contact contact)
    {
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            dbContext.ContactManagemen.Update(contact);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Unresolved application problem when updating contact to database: {ex.Message}", ex);
        }
    }
    public async Task DeleteContactAsync(Contact contact)
    {
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            dbContext.ContactManagemen.Remove(contact);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Unresolved application problem when deleting contact to database: {ex.Message}", ex);
        }
    }

}
