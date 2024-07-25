using Andela.Domain.Intefaces;
using Andela.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolApi.Services.StudentsRepository;

namespace Andela.Infrastructure
{

  public static class DependencyInjection
  {
    public static IServiceCollection AddPersistence (this IServiceCollection services, IConfiguration configuration)
    {
      var data = configuration.GetConnectionString("MySqlConnection"); 
      //----- MySQL connection
      services.AddDbContext<BaseContext>(options =>
        options.UseMySql(
            configuration.GetConnectionString("MySqlConnection"),
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));
      
      //----- Repository 
      services.AddScoped<IStudentRepository, StudentsRepository>();
    return services;
    }
  }
}
