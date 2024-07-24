namespace Andela.Domain.Common
{
    public abstract class BaseEntity<T>
    {
      public virtual T Id { get; set; }
    }
}