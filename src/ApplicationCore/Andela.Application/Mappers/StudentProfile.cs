using Andela.Domain.Entities;
using AutoMapper;

namespace Store.ApplicationCore.Mappings
{
  public class StudentProfile : Profile
  {
    public StudentProfile()
    {
      CreateMap<Student, StudentDTO>();
    }
  }
}