using Andela.Application.Services;
using Andela.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Andela.Api.Controllers.Students
{
  [Route("api/students")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class StudentsController: ControllerBase
  {
    private readonly StudentsService _studentsService;
    public StudentsController(StudentsService studentsService)
    {
      _studentsService = studentsService;
    }

    [HttpGet]
    public List<Student> GetAll()
    {
      return _studentsService.GetAll();
    }

    [HttpGet("{Id}")]
    public Student GetById(int Id)
    {
      return _studentsService.GetById(Id);
    }

    // // Query
    // [HttpGet]
    // [Route("query/paging")]
    // public PageResponse<IEnumerable<Student>> GetAll([FromQuery] int pageNumber)
    // {
    //   return _studentRepository.GetAll(pageNumber);
    // }

    // [HttpGet]
    // [Route("query/birthday")]
    // public Response<IEnumerable<Student>> GetStudentBirthDay([FromQuery] DateOnly value)
    // {
    //   return _studentRepository.GetStudentBirthDay(value);
    // }
  }
}