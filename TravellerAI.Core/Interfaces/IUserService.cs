using TravellerAI.Domain.Models;

namespace TravellerAI.Core.Interfaces;

public interface IUserService
{
    public Task<UserModel> GetUser(Guid userId);
    public Task<IEnumerable<UserModel>> GetUsers();
}