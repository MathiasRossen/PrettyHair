namespace PrettyHair.DAL
{
    public interface IEntityKeyGenerator
    {
        long NextKey { get; }
    }
}