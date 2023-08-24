using MartignaniDaniele.utils;

namespace MartignaniDaniele.entity
{
    public class EntityImpl : IEntity
    {
        public string Name { get; }
        public Position? Position { get; set; }

        protected EntityImpl(string name)
        {
            this.Name = name;
            
        }
    }
}