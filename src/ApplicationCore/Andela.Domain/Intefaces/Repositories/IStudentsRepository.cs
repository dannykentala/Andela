using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;
public interface IStudentsRepository
{
  IEnumerable<StudentDTO> GetAll();
  StudentDTO GetById(int id);
  StudentDTO Create(StudentDTO student);
  // StudentDTO Update(int id, StudentDTO student);
  // int Delete(int id);
}