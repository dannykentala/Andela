using Andela.Application.Services;
using Andela.Domain.Entities;
using Andela.Domain.Intefaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Andela.Api.Controllers.Students
{
  [Route("api/excel")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class ExcelController: ControllerBase
  {
    private readonly IExcelService _excelService;
    public ExcelController(IExcelService studentsService)
    {
      _excelService = studentsService;
    }

    [HttpPost]
    public void GetAll()
    {
      _excelService.UploadExcelToDb();
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