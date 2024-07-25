using Andela.Domain.Entities;
using Andela.Domain.Intefaces;

namespace Andela.Application.Services
{

  public class StudentsService
  {
    private readonly IStudentRepository _studentRepository;
    public StudentsService (IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public List<Student> GetAll()
    {
      var users = _studentRepository.GetAll();
      return users;
    }

    public Student GetById(int Id)
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