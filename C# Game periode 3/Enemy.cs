using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Game_periode_3
{
    internal class Enemy
    {
        public string name;
        public int eLevel;
        public int eMoneyDrop;
        public int eHpStat;
        public int eManaStat;
        public float eAtkStat;
        public float eDefStat;
        public float eMAtkStat;
        public float eMDefStat;

        public Enemy(string enemyName, int enemyLevel, int enemyMoneyDrop, int enemyHp, int enemyMana, float enemyAtk, float enemyDef, float enemyMAtk, float enemyMDef)
        {
            name = enemyName;
            eLevel = enemyLevel;
            eMoneyDrop = enemyMoneyDrop;
            eHpStat = enemyHp;
            eManaStat = enemyMana;
            eAtkStat = enemyAtk;
            eDefStat = enemyDef;
            eMAtkStat = enemyMAtk;
            eMDefStat = enemyMDef;
        }
    }
}
