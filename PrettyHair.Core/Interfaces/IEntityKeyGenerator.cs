namespace PrettyHair.Core.Entities
{
    interface IEntityKeyGenerator
    {
        long NextKey { get; }
    }
}