using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Player : Character
    {
        // NewConstructors//
        public Player(string name, Specialization role)
        {
            this.Name = name;
            this.Role = role;
            this.IsAlive = true;
            this.Health = 100;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }

        //Properties//
        public Specialization Role { get; set; }

        //Enums//
        public enum Specialization
        {
            NA,
            Business1,
            Business2,
            Business3,
            Business4,
            Business5
        }

        public enum Action
        {
            Attack,
            Run,
            Hide
        }
    }
}
