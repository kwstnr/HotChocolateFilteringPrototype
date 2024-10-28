using Microsoft.EntityFrameworkCore;
using Prototype.data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<PrototypeDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("PrototypeDb")));

builder.Services
    .AddGraphQLServer()
    .AddPrototype()
    .AddFiltering();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<PrototypeDbContext>().Database.Migrate();
}

app.MapGraphQL();

app.RunWithGraphQLCommands(args);