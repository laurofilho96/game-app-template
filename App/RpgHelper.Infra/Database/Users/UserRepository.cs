using Domain.Models.Users;
using RpgHelper.Domain.Models.Commons;
using RpgHelper.Infra.Interfaces.Users;

namespace RpgHelper.Infra.Database.Users;

public class UserRepository : IUserRepository
{
    public Task<bool> CreateContact(OperationResult<User> contact)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateUser(OperationResult<User> user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteContact(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ReadContacts(OperationResult<User> contact)
    {
        throw new NotImplementedException();
    }

    public Task<User> ReadUser(OperationResult<User> user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateContact(OperationResult<User> contact)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUser(OperationResult<User> user)
    {
        throw new NotImplementedException();
    }
}
