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
            //using (ChampionsModel context = new ChampionsModel())
            using (cloudChampionsModel context = new cloudChampionsModel())
            {
                //tblTest champion = new tblTest
                champion champion = new champion
                {
                    //name = inName, passive = inPassive, basead = inBasead
                    name = "Xayah", basead=64, passive="Clean Cuts"
                };
                try
                {
                    context.champions.Add(champion);
                    //context.tblTests.Add(champion);
                }
                catch { }
                context.SaveChanges();
                //context.SaveChangesAsync();
            }
        }


        public static List<string> getDB()//needs tested
        {
            //context.tblTests.Find("Jinx");
            //List<String> champList = new List<String>();
            //using (var db = new ChampionsModel())
            using (var db = new cloudChampionsModel())
            {
                var query = (//from c in db.tblTests
                             from c in db.champions
                             where c.name == "Lissandra"

                             select new { /*c.name,*/ c.passive, c.basead, c.imageLink });//test this pls
                query.ToString();
                var test = query.ToString();
                List<String> result = new List<string>();
                result.Add(test);
                return result;
            }
        }


        public static void selectDB()//needs tested
        {
            //using (ChampionsModel context = new ChampionsModel())
            using (cloudChampionsModel context = new cloudChampionsModel())
            {
                champion champion = context.champions.FirstOrDefault(r => r.name == "Lissandra");
                //tblTest champion = context.tblTests.FirstOrDefault(r => r.name == "Xayah");
                Console.WriteLine("You chose " + champion.name);
                Console.WriteLine("Their passive is "+ champion.passive);
                Console.WriteLine("Base AD is " + champion.basead);
                Console.WriteLine("Image link is " + champion.imageLink);
                //Console.ReadLine();
            }
        }
    }
}
