using RWAPP.CoreBusiness;
using RWAPP.DAL;
using RWAPP.Interface.Sqlite;
using RWAPP.UseCase.EventUseCase;
using RWAPP.UseCase.EventUseCase.Interface;
using RWAPP.UseCase.PluginInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EventContext>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddTransient<IAddNewEventUseCase, AddNewEventUseCase>();
builder.Services.AddTransient<IViewAllEventsByNameUseCase, ViewAllEventsByNameUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/v1/events", async (IViewAllEventsByNameUseCase viewAllUseCase) =>
{
    IEnumerable<Event> events = await viewAllUseCase.ExecuteAsync("");
    return Results.Ok(events);
});

app.MapPost("/api/v1/events", async (IAddNewEventUseCase addNewUseCase , Event e) =>
{
    await addNewUseCase.ExecuteAsync(e);
});

app.Run();

