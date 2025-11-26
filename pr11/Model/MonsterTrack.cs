using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pr11.Model
{
    internal class MonsterTrack
    {
        static Random rnd = new Random();

        public static Enemy CreateMonster (bool isBoss = false)
        {
            if (isBoss)
            {
                int type = rnd.Next(4);
                switch (type)
                {
                    case 0: return new GoblinBoss();
                    case 1: return new SkeletBossKova();
                    case 2: return new SkeletBossPest();
                    case 3: return new MagBoss();
                }
            }
            else
            {
                int type = rnd.Next(4);
                switch (type)
                {
                    case 0: return new Goblin();
                    case 1: return new Skelet();
                    case 2: return new Mag();
                    case 3: return new Slime();
                }
            }
            return null;
        }
    }
}
