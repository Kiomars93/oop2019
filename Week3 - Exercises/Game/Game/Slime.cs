using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game
{
    class Slime : GameEntity
    {
        public Slime() : base(50, 20, 5) { }
        public override string Name => "Slime";

        

        public override bool StrongAgainst(GameEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
