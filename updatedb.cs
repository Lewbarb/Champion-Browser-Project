using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionBrowser
{
    class updatedb//adds records to database
    {
        //public static void pushDB(string inName, string inPassive, int inBasead)/
        public static void pushDB(string name, int hp, int hpregen, int mana, int manaregen, int range, int ad, float attackspeed, int armour, int mr, int speed, int bluePrice, int rpPrice, string Q, string W, string E, string R, string passive, string imageLink)
        {
            //using (ChampionsModel context = new ChampionsModel())
            using (cloudChampionsModel context = new cloudChampionsModel())
            {
                //tblTest champion = new tblTest
                champion champion = new champion
                {
                    //name = inName, passive = inPassive, basead = inBasead
                    //name = "Xayah", basead=64, passive="Clean Cuts"
                    //name = name, basehp = hp, hpregen = hpregen, basemana = mana, basemanaregen=manaregen, range = range, basead = ad, baseattackspeed = attackspeed, basearmour = armour, basemr = mr, basespeed = speed, bluePrice = bluePrice, rpPrice = rpPrice, Q = Q, W = W, E = E, R = R, passive = passive, imageLink = imageLink
                    name = name.Trim(),
                    basehp = hp,
                    hpregen = hpregen,
                    basemana = mana,
                    basemanaregen = manaregen,
                    range = range,
                    basead = ad,
                    baseattackspeed = attackspeed,
                    basearmour = armour,
                    basemr = mr,
                    basespeed = speed,
                    bluePrice = bluePrice,
                    rpPrice = rpPrice,
                    Q = Q.Trim(),
                    W = W.Trim(),
                    E = E.Trim(),
                    R = R.Trim(),
                    passive = passive.Trim(),
                    imageLink = imageLink.Trim()
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


        public static void editRecord(string name, int hp, int hpregen, int mana, int manaregen, int range, int ad, float attackspeed, int armour, int mr, int speed, int bluePrice, int rpPrice, string Q, string W, string E, string R, string passive, string imageLink)
        {
            //using (ChampionsModel context = new ChampionsModel())
            using (cloudChampionsModel db = new cloudChampionsModel())
            {
                //tblTest champion = new tblTest
                champion champion = new champion
                {
                    //name = inName, passive = inPassive, basead = inBasead
                    //name = "Xayah", basead=64, passive="Clean Cuts"
                    name = name.TrimEnd(),
                    basehp = hp,
                    hpregen = hpregen,
                    basemana = mana,
                    basemanaregen = manaregen,
                    range = range,
                    basead = ad,
                    baseattackspeed = attackspeed,
                    basearmour = armour,
                    basemr = mr,
                    basespeed = speed,
                    bluePrice = bluePrice,
                    rpPrice = rpPrice,
                    Q = Q.TrimEnd(),
                    W = W.TrimEnd(),
                    E = E.TrimEnd(),
                    R = R.TrimEnd(),
                    passive = passive.TrimEnd(),
                    imageLink = imageLink.TrimEnd()
                };
                var original = db.champions.Find(champion.name);
                if (original != null)
                {
                    db.Entry(original).CurrentValues.SetValues(champion);
                    var test = champion.passive;
                    db.SaveChanges();
                }
                
                //db.champions.Attach(champion);
                //db.SaveChanges();
                //context.SaveChangesAsync();
            }
        }


        public static void deleteRecord(string name)
        {
            //using (ChampionsModel context = new ChampionsModel())
            using (cloudChampionsModel context = new cloudChampionsModel())
            {
                //tblTest champion = new tblTest
                champion champion = new champion
                {
                    name = name,
                };
                try
                {
                    context.champions.Attach(champion);
                    context.champions.Remove(champion);
                    //context.tblTests.Add(champion);
                }
                catch { }
                context.SaveChanges();
                //context.SaveChangesAsync();
            }
        }

        public static List<string> getDB(string searchName)//needs tested
        {
            //context.tblTests.Find("Jinx");
            //List<String> champList = new List<String>();
            //using (var db = new ChampionsModel())
            using (var db = new cloudChampionsModel())
            {
                var query = (//from c in db.tblTests
                             from c in db.champions
                                 //where c.name == "Lissandra"
                             where c.name == searchName
                             select new { /*c.name,*/ c.passive, c.basead, c.imageLink });//test this pls
                query.ToString();
                var test = query.ToString();
                List<String> result = new List<string>();
                result.Add(test);
                return result;
            }
        }
        
        public static champion searchDB(string searchName)//searched table for object with name equal to passed string
        {
            using (cloudChampionsModel context = new cloudChampionsModel())
            {
                champion championObj = context.champions.FirstOrDefault(r => r.name == searchName);
                return championObj;
            }
        }
        

        public static List<champion> championList()
        {
            //List<champion> myList = new List<champion>();
            using (cloudChampionsModel champs = new cloudChampionsModel())
            {
                var champList = champs.champions;
                var db = champList.ToList();//creates list of every champion in database as an object into the variable 'db'
                //db.Find(c => c.name == "Lissandra");
                return champList.ToList();

            }
        }





        
        public static void selectDBtest()//needs tested
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
