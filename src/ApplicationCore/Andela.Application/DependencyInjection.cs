using Andela.Application.Services;
using Andela.Domain;
using Andela.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationCore.Mappings;

namespace Andela.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication (this IServiceCollection services)
    {
      //----- Repository 
      services.AddScoped<StudentsService>();

      //----- Automaper
      services.AddAutoMapper(typeof(StudentProfile));

      return services;
    }
  }
}
