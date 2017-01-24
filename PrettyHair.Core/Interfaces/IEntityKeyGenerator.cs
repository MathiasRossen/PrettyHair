namespace PrettyHair.Core.Entities
{
    public interface IEntityKeyGenerator
    {
        long NextKey { get; }
    }
}