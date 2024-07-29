namespace Andela.Domain.Entities
{
  public class Enrollment
  {
    public int Id { get; set; }
    public string Status { get; set; }
    public int StudentId { get; set; }
    public int ClassId { get; set; }
    // public Student Student { get; set; }
    // public Class Class { get; set; }
  }
}