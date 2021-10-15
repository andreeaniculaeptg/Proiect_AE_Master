namespace Puzzle4UbyNAM.Models
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
