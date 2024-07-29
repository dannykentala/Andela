using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;

public interface ISemestersRepository
{
  IEnumerable<SemesterDTO> GetAll();
  SemesterDTO GetById(int id);
  SemesterDTO Create(SemesterDTO semester);
  // SemesterDTO Update(int id, SemesterDTO semester);
  // int Delete(int id);
}