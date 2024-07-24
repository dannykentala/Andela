using Andela.Domain.Common;

namespace Andela.Domain.Models
{
    public abstract class Student: BaseEntity<int>
    {
      public string Name { get; set; }
    }
}