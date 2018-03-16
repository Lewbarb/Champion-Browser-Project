using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class Champion
    {
        //champion atrributes
        string name;
        int basehp;
        int hpregen;
        int basemana;
        int basemanaregen;
        int range;
        int basead;
        int baseatckspeed;
        int baseap;
        int basearmour;
        int basemr;
        int basespeed;
        int bluePrice;
        int rpPrice;
        string Q;
        string W;
        string E;
        string R;

        //add more

        Champion (string name, int basehp, int basemana, int basead, int baseap, int basearmor, int basemr)//Champion constructor
        {
            this.name = name;
            this.basehp = basehp; //health
            this.hpregen = hpregen; //health regen
            this.basemana = basemana;
            this.basemanaregen = basemanaregen;
            this.range = range;
            this.basead = basead; //attack damage
            this.baseatckspeed = baseatckspeed; //attack speed
            this.baseap = baseap; //ability power
            this.basearmour = basearmour;
            this.basemr = basemr; //magic resist
            this.basespeed = basespeed;
            this.bluePrice = bluePrice; //blue essence required to purchase
            this.rpPrice = rpPrice; //riot points required to purchase
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.R =R;
        }
    }
}
