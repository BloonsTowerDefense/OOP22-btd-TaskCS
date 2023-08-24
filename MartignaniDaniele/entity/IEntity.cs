using MartignaniDaniele.utils;

namespace MartignaniDaniele.entity
{
    public interface IEntity
    {
        Position? Position { get; set; }

        string Name { get; }
    }
}