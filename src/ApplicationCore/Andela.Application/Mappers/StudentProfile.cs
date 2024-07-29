using Andela.Domain.DTOs;
using Andela.Domain.Entities;
using AutoMapper;

namespace Andela.Application.Mappers
{
  public class StudentProfile : Profile
  {
    public StudentProfile()
    {
      CreateMap<Student, StudentDTO>();
      CreateMap<StudentDTO, Student>();
    }
  }
}