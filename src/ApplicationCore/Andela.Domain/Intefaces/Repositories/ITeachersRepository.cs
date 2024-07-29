using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;

public interface ITeachersRepository
{
  IEnumerable<TeacherDTO> GetAll();
  TeacherDTO GetById(int id);
  TeacherDTO Create(TeacherDTO teacher);
  // TeacherDTO Update(int id, TeacherDTO teacher);
  // int Delete(int id);
}