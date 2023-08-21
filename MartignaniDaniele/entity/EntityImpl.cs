using MartignaniDaniele.utils;
using MartignaniDaniele.entity;

namespace MartignaniDaniele.entity
{
    // Represents a basic implementation of the IEntity interface in the tower defense game,
    // which can have a position and a name.
    public class EntityImpl : IEntity
    {
        public string Name { get; }
        public Position? Position { get; set; }

        // Constructs an EntityImpl object with the specified name and no initial position.
        protected EntityImpl(string name)
        {
            this.Name = name;
            
        }
    }
}