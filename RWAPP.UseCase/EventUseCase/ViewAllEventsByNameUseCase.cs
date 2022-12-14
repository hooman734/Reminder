using RWAPP.CoreBusiness;
using RWAPP.UseCase.EventUseCase.Interface;
using RWAPP.UseCase.PluginInterface;

namespace RWAPP.UseCase.EventUseCase;

public class ViewAllEventsByNameUseCase : IViewAllEventsByNameUseCase
{
    private readonly IRepository _repository;

    public ViewAllEventsByNameUseCase(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Event>> ExecuteAsync(string name = "")
    {
        return await _repository.GetAll(name);
    }
}