using RWAPP.CoreBusiness;

namespace RWAPP.UseCase.EventUseCase.Interface;

public interface IViewAllEventsByNameUseCase
{
    public Task<IEnumerable<Event>> ExecuteAsync(string name);
}