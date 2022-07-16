using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRSCombatCalc
{
    internal class Account
    {
        //properties
        public int attackLevel { get; set; }
        public int strengthLevel { get; set; }
        public int defenceLevel { get; set; }
        public int rangedLevel { get; set; }
        public int prayerLevel { get; set; }
        public int magicLevel { get; set; }
        public int hpLevel { get; set; }
        //constructor
        public Account(int _attackLevel, int _strengthLevel, int _defenceLevel, int _rangedLevel, int _prayerLevel, int _magicLevel, int _hpLevel)
        {
            attackLevel = _attackLevel;
            strengthLevel = _strengthLevel;
            defenceLevel = _defenceLevel;
            rangedLevel = _rangedLevel;
            prayerLevel = _prayerLevel;
            magicLevel = _magicLevel;
            hpLevel = _hpLevel;
        }
    }
}
