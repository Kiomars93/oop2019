using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game
{
    class Dragon : GameEntity
    {
        public override string Name => "Dragon";

        public Dragon(): base(2000,200, 30)
        {

        }

        public override bool WeakAgainst(GameEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool StrongAgainst(GameEntity entity)
        {
            if ((entity is Human) || (entity is Monster))
            {
                return true;
            }
            return false;
        }

    }
}
