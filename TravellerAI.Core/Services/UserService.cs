using TravellerAI.Core.Interfaces;
using TravellerAI.Domain.Models;

namespace TravellerAI.Core.Services;

public class UserService: IUserService
{
    public async Task<UserModel> GetUser(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UserModel>> GetUsers()
    {
        throw new NotImplementedException();
    }
}