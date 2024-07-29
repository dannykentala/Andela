namespace Andela.Domain.Entities
{
  public class Degree
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int UniversityId { get; set; }
    
    // // Navigation property
    // public University University { get; set; }
  }
}