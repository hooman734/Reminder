using System.Globalization;
using RWAPP.CoreBusiness;
using RWAPP.UseCase.PluginInterface;

namespace RWAPP.Interface.InMemory;

public class Repository : IRepository
{
    private readonly List<Event> _data;

    public Repository()
    {
        _data = new()
        {
            new Event() {Name = "Study", Description = "Do your homeworks by practicing on some projects", Link = "https://google.com", DueDate = DateTime.Now},
            new Event() {Name = "meeting", Description = "enjoy your meeting with your colleagues and discus about the blockages", Link = "https://yahoo.com", DueDate = DateTime.Now},
            new Event() {Name = "shop", Description = "buy groceries from the nearby supermarket", Link = "https://msn.com", DueDate = DateTime.Now},
            new Event() {Name = "jogging", Description = "walk in a daily routine which helps you to keep your body fit", Link = "https://yahoo.com", DueDate = DateTime.Now},
        };
    }
    
    public async Task<IEnumerable<Event>> GetAll(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return await Task.FromResult(_data);
        }

        return _data.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
    }

    public async Task Add(Event e)
    {
        _data.Add(e);
        await Task.CompletedTask;
    }
}