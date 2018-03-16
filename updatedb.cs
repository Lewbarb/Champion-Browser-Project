using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class updatedb
    {
        public static void pushDB()
        {
            using (ChampionsModel context = new ChampionsModel())
            {
                tblTest champion = new tblTest
                {
                    name = "test"//,passive = "Get Exited", basead = 625
                };
                context.tblTests.Add(champion);
                context.SaveChanges();
            }
            
        }
    }
}
