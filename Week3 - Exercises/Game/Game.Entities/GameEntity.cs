namespace Game.Entities
{
    public abstract class GameEntity
    {
        public int Health;
        public int Damage;
        public abstract string Name { get; }
        public bool Dead => Health <= 0;
        public GameEntity(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        public abstract bool WeakAgainst(GameEntity entity);
        public abstract bool StrongAgainst(GameEntity entiy);
    }
}
