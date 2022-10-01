using RWAPP.CoreBusiness;
using RWAPP.UseCase.EventUseCase.Interface;
using RWAPP.UseCase.PluginInterface;

namespace RWAPP.UseCase.EventUseCase;

public class AddNewEventUseCase : IAddNewEventUseCase
{
    private readonly IRepository _repository;

    public AddNewEventUseCase(IRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(Event e)
    {
        await _repository.Add(e);
    }
}