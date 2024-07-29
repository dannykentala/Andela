using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;
public interface IClassesRepository
{
  IEnumerable<ClassDTO> GetAll();
  ClassDTO GetById(int id);
  ClassDTO Create(ClassDTO classEntity);
  // ClassDTO Update(int id, ClassDTO classEntity);
  // int Delete(int id);
}
