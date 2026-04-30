using Domain.Models.Users;
using RpgHelper.Domain.Models.Commons;

namespace RpgHelper.Infra.Interfaces.Users;

public interface IUserRepository
{
    Task<bool> CreateUser(OperationResult<User> user);
    Task<User> ReadUser(OperationResult<User> user);
    Task<bool> UpdateUser(OperationResult<User> user);
    Task<bool> DeleteUser(int id);

    //Operação fora do crud principal
    Task<bool> CreateContact(OperationResult<User> contact);
    Task<bool> ReadContacts(OperationResult<User> contact);
    Task<bool> UpdateContact(OperationResult<User> contact);
    Task<bool> DeleteContact(int id);
}
