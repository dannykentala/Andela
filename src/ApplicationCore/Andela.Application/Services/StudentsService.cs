using Andela.Domain.Entities;
using Andela.Domain.Intefaces.Repositories;

namespace Andela.Application.Services
{

  public class StudentsService
  {
    private readonly IStudentRepository _studentRepository;
    public StudentsService (IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public IEnumerable<StudentDTO> GetAll()
    {
      var users = _studentRepository.GetAll();
      return users;
    }

    public StudentDTO GetById(int Id)
    {
      var student = _studentRepository.GetById(Id);
      return student;
    }

    // public void CreateUser(UserDto userDto)
    // {
    //     var user = UserMapper.MapToEntity(userDto);
    //     _studentRepository.AddUser(user);
    // }
  }
}