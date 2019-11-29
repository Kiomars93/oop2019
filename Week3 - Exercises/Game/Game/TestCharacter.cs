using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class TestCharacter : GameEntity
    {

        public TestCharacter(int health, int damage) : base(health,damage)
        {

        }
        public override string Name => throw new NotImplementedException();

        public override bool StrongAgainst(GameEntity entiy)
        {
            throw new NotImplementedException();
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
