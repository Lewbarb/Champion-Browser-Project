using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class updatedb
    {
        public static void pushDB(string inName, string inPassive, int inBasead)
        {
            using (ChampionsModel context = new ChampionsModel())
            {
                //context.tblTests.Find("Jinx");
                tblTest champion = new tblTest
                {
                    name = inName, passive = inPassive, basead = inBasead
                };
                try
                {
                    context.tblTests.Add(champion);
                }
                catch { }
                context.SaveChanges();
                //context.SaveChangesAsync();
            }
        }
    }
}
