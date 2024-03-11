using C__Game_periode_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Game_periode_3
{
    public class Player
    {
        public string name;
        public int pLevel;
        public int pMoney;
        public int pHpStat;
        public int pManaStat;
        public float pAtkStat;
        public float pDefStat;
        public float pMAtktStat;
        public float pMDefStat;

        public Player(int playerLevel, int playerMoney, int playerHp, int playerMana, float playerAtk, float playerDef, float playerMAtk, float playerMDef)
        {
            pLevel = playerLevel;
            pMoney = playerMoney;
            pHpStat = playerHp;
            pManaStat = playerMana;
            pAtkStat = playerAtk;
            pDefStat = playerDef;
            pMAtktStat = playerMAtk;
            pMDefStat = playerMDef;

        }
    }
}