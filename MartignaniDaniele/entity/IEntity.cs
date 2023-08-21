using MartignaniDaniele.utils;

namespace MartignaniDaniele.entity
{
    // Represents an entity in the tower defense game, which can have a position and a name.
    public interface IEntity
    {
        // Returns an optional position of the entity.
        Position? Position { get; set; }

        // Returns the name of the entity.
        string Name { get; }
    }
}