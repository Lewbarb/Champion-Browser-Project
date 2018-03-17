using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class updatedb
    {
        //public static void pushDB(string inName, string inPassive, int inBasead)//adds items to database
        public static void pushDB()
        {
            using (ChampionsModel context = new ChampionsModel())
            {
                tblTest champion = new tblTest
                {
                    //name = inName, passive = inPassive, basead = inBasead
                    name = "Xayah", basead=64, passive="Clean Cuts"
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
                             where c.name == "Xayah"
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
                tblTest champion = context.tblTests.FirstOrDefault(r => r.name == "Xayah");
                Console.WriteLine("You chose " + champion.name);
                Console.WriteLine("Their passive is "+ champion.passive);
                Console.WriteLine("Base AD is " + champion.basead);
                //Console.ReadLine();
            }
        }





    }
}
