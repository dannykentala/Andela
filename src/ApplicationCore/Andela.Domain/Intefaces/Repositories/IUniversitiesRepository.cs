using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;

public interface IUniversitiesRepository
{
  IEnumerable<UniversityDTO> GetAll();
  UniversityDTO GetById(int id);
  UniversityDTO Create(UniversityDTO teacher);
  // UniversityDTO Update(int id, UniversityDTO teacher);
  // int Delete(int id);
}