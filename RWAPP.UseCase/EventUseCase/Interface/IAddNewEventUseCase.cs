using RWAPP.CoreBusiness;

namespace RWAPP.UseCase.EventUseCase.Interface;

public interface IAddNewEventUseCase
{
    public Task ExecuteAsync(Event e);
}