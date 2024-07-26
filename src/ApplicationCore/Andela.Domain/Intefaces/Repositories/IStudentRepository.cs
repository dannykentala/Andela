using Andela.Domain.Entities;

namespace Andela.Domain.Intefaces.Repositories
{
  public interface IStudentRepository
  {
    IEnumerable<StudentDTO> GetAll();
    StudentDTO GetById(int Id);
  }
}
