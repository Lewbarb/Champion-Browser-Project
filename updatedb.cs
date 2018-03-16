using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class updatedb
    {
        public static void pushDB(string inName, string inPassive, int inBasead)//adds items to database
        {
            using (ChampionsModel context = new ChampionsModel())
            {
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


        public List<string> getDB()//needs tested
        {
            //context.tblTests.Find("Jinx");
            //List<String> champList = new List<String>();
            using (var db = new ChampionsModel())
            {
                var query = (from c in db.tblTests
                             where c.name == "Jinx"
                             select new { c.passive, c.basead });
                query.ToString();
                var test = query.ToString();
                List<String> result = new List<string>();
                result.Add(test);
                return result;
            }
        }


        public static void selectDB()//needs tested
        {
            using (ChampionsModel context = new ChampionsModel())
            {
                tblTest champion = context.tblTests.FirstOrDefault(r => r.name == "Sion");
                Console.WriteLine(champion.name);
                Console.WriteLine(champion.passive);
                Console.WriteLine(champion.basead);
                Console.ReadLine();
            }
        }





    }
}
