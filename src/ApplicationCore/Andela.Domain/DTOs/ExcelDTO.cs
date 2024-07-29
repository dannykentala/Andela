namespace Andela.Domain.DTOs;
public class ExcelDTO
{
  public StudentDTO Student { get; set; }
  public TeacherDTO Teacher { get; set; }
  public ClassDTO Class { get; set; }
  public UniversityDTO University { get; set; }
  public SemesterDTO Semester { get; set; }
  public DegreeDTO Degree { get; set; }
  public EnrollmentDTO Enrollment { get; set; }
}