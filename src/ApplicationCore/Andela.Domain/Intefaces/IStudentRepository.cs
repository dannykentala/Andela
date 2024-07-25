using Andela.Domain.Entities;

namespace Andela.Domain.Intefaces
{
  public interface IStudentRepository
  {
    IEnumerable<StudentDTO> GetAll();
    StudentDTO GetById(int Id);
  }
}
