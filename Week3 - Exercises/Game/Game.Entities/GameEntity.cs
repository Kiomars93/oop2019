namespace Game.Entities
{
    public abstract class GameEntity
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Agility { get; set; }
        public abstract string Name { get; }
        public bool Dead => Health <= 0;
        public GameEntity(int health, int damage, int agility)
        {
            this.Health = health;
            this.Damage = damage;
            this.Agility = agility;
        }

        public abstract bool WeakAgainst(GameEntity entity);
        public abstract bool StrongAgainst(GameEntity entity);

    }
}
