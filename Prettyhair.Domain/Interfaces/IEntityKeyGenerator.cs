namespace PrettyHair.Domain.Interfaces
{
    public interface IEntityKeyGenerator
    {
        long NextKey { get; }
    }
}