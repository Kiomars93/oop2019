using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GameEngine
    {
         public static Random random = new Random();

        public GameEngine()
        {
            
        }
        public int attack(GameEntity attacker, GameEntity defender)
        {
            var damage = (double)random.Next(attacker.Damage / 10, attacker.Damage);

            var attackerAgility = random.Next(0, attacker.Agility);

            var defenderAgility = random.Next(0, defender.Agility);

            if (attackerAgility > defenderAgility)
            {
                attacker.StrongAgainst(defender);
            } else if (attackerAgility < defenderAgility)
            {
                defender.StrongAgainst(attacker);
            }

            if (attacker.StrongAgainst(defender))
            {
                damage *= 1.2;
            }

            if (defender.WeakAgainst(attacker))
            {
                damage *= 1.2;
            }

            defender.Health -= (int)damage;

            return (int)damage;
    }
        public (GameEntity First, GameEntity Second) RollForInitiative(GameEntity a, GameEntity b)
        {
            var firstRoll = random.Next(0, a.Agility);
            var secondRoll = random.Next(0, b.Agility);
            
            do
            {
                if (firstRoll > secondRoll)
                {
                    return (a, b);
                }
                else if (firstRoll < secondRoll)
                {
                    return (b, a);
                }
            } while (firstRoll == secondRoll);

            return (b,b);
        }
        public void Battle(GameEntity a, GameEntity b)
        {
            // om a eller b dör så ska det ej kunna attackera måste använda bool dead här
        }
    }

    
}
