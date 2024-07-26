using Andela.Domain.Entities;
using Andela.Domain.Intefaces.Repositories;
using Andela.Infrastructure.Data;
using AutoMapper;

namespace Andela.Infrastructure.Repository
{
  public class StudentsRepository: IStudentRepository
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

  }
}