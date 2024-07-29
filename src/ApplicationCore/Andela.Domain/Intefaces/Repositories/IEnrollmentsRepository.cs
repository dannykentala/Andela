using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;
public interface IEnrollmentsRepository
{
  IEnumerable<EnrollmentDTO> GetAll();
  EnrollmentDTO GetById(int id);
  EnrollmentDTO Create(EnrollmentDTO enrollment);
  // EnrollmentDTO Update(int id, EnrollmentDTO enrollment);
  // int Delete(int id);
}
