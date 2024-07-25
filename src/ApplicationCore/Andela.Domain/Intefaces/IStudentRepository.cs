using Andela.Domain.Entities;

namespace Andela.Domain.Intefaces
{
  public interface IStudentRepository
  {
    List<Student> GetAll();
    Student GetById(int Id);
  }
}
