namespace TravellerAI.Core.Interfaces;

public interface IBudgetService
{
    public Task<string> CalculateBudget(Guid userId, Guid journeyId);
}