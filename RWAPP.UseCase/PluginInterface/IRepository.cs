using RWAPP.CoreBusiness;

namespace RWAPP.UseCase.PluginInterface;

public interface IRepository
{
    public Task<IEnumerable<Event>> GetAll(string name);
}