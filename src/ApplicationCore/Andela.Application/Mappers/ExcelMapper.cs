using Andela.Domain.DTOs;
using Andela.Domain.Enums;

namespace Andela.Application.Mappers
{
  public class ExcelMapper
  {
    private List<string> _excelRegister;
    public ExcelDTO ExcelRegisterToExcelDTO(List<string> excelRegister)
    {
      SetExcelRegister(excelRegister);

      ExcelDTO studentDTO = new ExcelDTO()
      {
        Student = new StudentDTO()
        {
          FirstName = GetRegister(ExcelEnum.StudentFirstName),
          LastName = GetRegister(ExcelEnum.StudentLastName),
          Email = GetRegister(ExcelEnum.StudentEmail),
          Phone = GetRegister(ExcelEnum.StudentPhone)
        },
        Teacher = new TeacherDTO()
        {
          FirstName = GetRegister(ExcelEnum.TeacherFirstName),
          LastName = GetRegister(ExcelEnum.TeacherLastName),
          Email = GetRegister(ExcelEnum.TeacherEmail),
          Phone = GetRegister(ExcelEnum.TeacherPhone)
        },
        Semester = new SemesterDTO()
        {
          Name = GetRegister(ExcelEnum.Year)
        },
        Degree = new DegreeDTO()
        {
          Name = GetRegister(ExcelEnum.Degree)
        },
        University = new UniversityDTO()
        {
          Name = GetRegister(ExcelEnum.University),
          ProvostName = GetRegister(ExcelEnum.ProvostName)
        },
        Enrollment = new EnrollmentDTO()
        {
          Id = int.Parse(GetRegister(ExcelEnum.RegisterId)),
          Status = GetRegister(ExcelEnum.RegisterStatus),
        }

      };

      return studentDTO;
    }

    private string GetRegister(ExcelEnum excelEnum)
    {
      return _excelRegister[(int) excelEnum];
    }

    private void SetExcelRegister(List<string> excelRegister)
    {
      _excelRegister = excelRegister;
    }
  }
}