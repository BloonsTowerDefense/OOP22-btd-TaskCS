namespace MartignaniDaniele.entity
{

    public class BloonImpl : EntityImpl, IBloon
    {
        public double Health { get; set; }
        public double Speed { get; set; }
        public int Money { get; }
        private bool alive;
        public BloonType BloonType { get; }

        public BloonImpl(BloonType type) : base(type.ToString())
        {
            this.BloonType = type;
            this.Health = type.GetHealth();
            this.Speed = type.GetSpeed();
            this.Money = type.GetMoney();
            this.alive = true;
        }


        public bool HasReachedEnd()
        {
            throw new NotImplementedException();
        }

        public void Hit(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                alive = false;
            }
        }

        public void Move(long time)
        {
            throw new NotImplementedException();
        }

        public void Update(long time)
        {
            throw new NotImplementedException();
        }

        public bool IsDead()
        {
            return !alive;
        }

        
    }
}
