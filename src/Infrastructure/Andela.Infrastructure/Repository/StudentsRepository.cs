using Andela.Domain.Entities;
using Andela.Domain.Intefaces;
using Andela.Infrastructure.Data;

namespace SchoolApi.Services.StudentsRepository
{
  public class StudentsRepository: IStudentRepository
  {
    private readonly BaseContext _context;

    public StudentsRepository(BaseContext context)
    {
      _context = context;
    }

    public List<Student> GetAll()
    {
      var data = _context.Students.ToList();
      return data;
    }

    public Student GetById(int Id)
    {
      var data = _context.Students.Find(Id);
      return data;
    }

  }
}