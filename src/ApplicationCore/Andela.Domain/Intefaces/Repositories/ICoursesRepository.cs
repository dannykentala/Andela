using Andela.Domain.DTOs;

namespace Andela.Domain.Intefaces.Repositories;

public interface ICoursesRepository
{
  IEnumerable<CourseDTO> GetAll();
  CourseDTO GetById(int id);
  CourseDTO Create(CourseDTO course);
  // CourseDTO Update(int id, CourseDTO course);
  // int Delete(int id);
}
