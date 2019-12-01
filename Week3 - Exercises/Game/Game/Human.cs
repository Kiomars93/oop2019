using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game
{
    class Human : GameEntity
    {
        public override string Name => "Human";

        public Human() : base(200, 50, 10) { }

        public override bool WeakAgainst(GameEntity entity)
        {
            //if(entity is Monster) { 
            //return true;
            //    }
            return false;
        }
        public override bool StrongAgainst(GameEntity entity)
        {
            if (entity is Monster)
            {
                Damage += 10;
                return true;
            }
            return false;
        }
    }
}
