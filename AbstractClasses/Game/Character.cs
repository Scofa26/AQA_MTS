using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public abstract class Character
    {
        public int level;
        public string name;

        protected Character(int level)
        {
            this.level = level;
        }

        public abstract void Move();
        public abstract void Attack();
        public abstract void UseAbility();

        public void PrintInfo() { Console.WriteLine($"name = {name} level = {level}"); }

    }
}
