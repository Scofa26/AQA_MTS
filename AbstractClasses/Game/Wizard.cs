using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public class Wizard : Character
    {
        public Wizard(int level) : base(level)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior is attacking");
        }

        public override void Move()
        {
            Console.WriteLine("Warrior is attacking");
        }

        public override void UseAbility()
        {
            Console.WriteLine("Warrior is attacking");
        }
    }
}
