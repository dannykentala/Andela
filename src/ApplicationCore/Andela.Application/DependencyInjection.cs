using Andela.Application.Services;
using Andela.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Andela.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication (this IServiceCollection services)
    {
      //----- Repository 
      services.AddScoped<StudentsService>();
    return services;
    }
  }
}
