using Andela.Domain.DTOs;
using Andela.Domain.Entities;
using Andela.Domain.Intefaces.Repositories;
using Andela.Infrastructure.Data;
using AutoMapper;

namespace Andela.Infrastructure.Repository
{
  public class StudentsRepository: IStudentsRepository
  {
    private readonly BaseContext _context;
    private readonly IMapper _mapper;

    public StudentsRepository(BaseContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public IEnumerable<StudentDTO> GetAll()
    {
      var data = _context.Students.ToList();
      IEnumerable<StudentDTO> studentDTOs = _mapper.Map<IEnumerable<StudentDTO>>(data);
      return studentDTOs;
    }

    public StudentDTO GetById(int Id)
    {
      var data = _context.Students.Find(Id);
      StudentDTO studentDTO = _mapper.Map<StudentDTO>(data);
      return studentDTO;
    }

    public StudentDTO Create(StudentDTO data)
    {
      Student student = _mapper.Map<Student>(data);
      _context.Students.Add(student);
      _context.SaveChanges();
      return data;
    }

    // public StudentDTO Update(int id, StudentDTO student)
    // {
    //   var existingStudent = _context.Students.Find(id);
    //   if (existingStudent == null) return null;

    //   existingStudent.FirstName = student.FirstName;
    //   existingStudent.LastName = student.LastName;
    //   existingStudent.Email = student.Email;
    //   existingStudent.Phone = student.Phone;
      
    //   _context.Students.Update(existingStudent);
    //   _context.SaveChanges();
    //   return existingStudent;
    // }

    // public int Delete(int id)
    // {
    //   var student = _context.Students.Find(id);
    //   if (student == null) return 0;

    //   _context.Students.Remove(student);
    //   return _context.SaveChanges();
    // }
  }
}