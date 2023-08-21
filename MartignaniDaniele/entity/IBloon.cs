using MartignaniDaniele.entity;

namespace MartignaniDaniele.entity
{
    public interface IBloon : IEntity
    {
        double Health { get; set; }

        int Money { get; }

        double Speed { get; set; }

        bool HasReachedEnd();

        void Hit(int damage);

        void Move(long time);

        void Update(long time);

        bool IsDead();

        BloonType BloonType { get; }
    }
}