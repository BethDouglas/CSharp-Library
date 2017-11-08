using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._011_OOPGameBuildAlong
{
    class Player : Character
    {
        //Constructors//
        public Player(string name, Specialization role)
        {
            this.Name = name;
            this.Role = role;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }
        
        //Properties//
        public Specialization Role { get; set; }

        //Enums//
        public enum Specialization
        {
            NA = 0,
            Business1 = 1,
            Business2 =2,
            Business3 = 3,
            Business4 = 4,
            NotYoursInc = 5,
        }

        public enum Action
        {
            Attack = 0,
            HeadButt = 1,
            EarBox = 2,
        }
    }
}
