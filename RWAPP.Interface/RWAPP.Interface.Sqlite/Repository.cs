using Microsoft.EntityFrameworkCore;
using RWAPP.CoreBusiness;
using RWAPP.DAL;
using RWAPP.UseCase.PluginInterface;

namespace RWAPP.Interface.Sqlite;

public class Repository : IRepository
{
    private readonly EventContext _eventContext;

    public Repository(EventContext eventContext)
    {
        _eventContext = eventContext;
    }
    public async Task<IEnumerable<Event>> GetAll(string name)
    {
        return await _eventContext.Events!.ToListAsync();
    }

    public async Task Add(Event e)
    {
        if (e == null)
        {
            throw new ArgumentNullException(nameof(e));
        }

        await _eventContext.AddAsync(e);
        await _eventContext.SaveChangesAsync();
    }
}