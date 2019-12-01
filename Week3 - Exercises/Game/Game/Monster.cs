using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Monster : GameEntity
    {
        public override string Name => "Monster";

        public Monster(): base(150, 100, 10) { }

        public override bool StrongAgainst(GameEntity entity)
        {
            return true;
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            if (entity is Human)
            {
                return true;
            }
            return false;
        }
    }
}
