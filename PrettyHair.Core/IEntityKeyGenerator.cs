namespace PrettyHair.Core
{
    public interface IEntityKeyGenerator
    {
        long NextKey { get; }
    }
}