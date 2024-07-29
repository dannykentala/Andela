using Andela.Application.Mappers;
using Andela.Application.Services;
using Andela.Domain;
using Andela.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

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

      services.AddScoped<ExcelMapper>();

      return services;
    }
  }
}
