using Andela.Infrastructure;
using Andela.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//----- BEGIN PERSONAL SERVICES -----//
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication();

//----- END PERSONAL SERVICES -----//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
