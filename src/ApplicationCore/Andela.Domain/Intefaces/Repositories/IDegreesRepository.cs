using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;
public interface IDegreesRepository
{
  IEnumerable<DegreeDTO> GetAll();
  DegreeDTO GetById(int id);
  DegreeDTO Create(DegreeDTO degree);
  // DegreeDTO Update(int id, DegreeDTO degree);
  // int Delete(int id);
}
