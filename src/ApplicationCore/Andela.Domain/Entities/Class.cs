namespace Andela.Domain.Entities
{
  public class Class
  {
    public int Id { get; set; }
    public DateTime Year { get; set; }
    public int SemesterId { get; set; }
    public int TeacherId { get; set; }
    public int CourseId { get; set; }
    
    // Navigation properties
    // public Semester Semester { get; set; }
    // public Teacher Teacher { get; set; }
    // public Course Course { get; set; }
  }
}