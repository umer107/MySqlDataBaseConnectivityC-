using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    class Program
    {
      
        static void Main(string[] args)
        {
            zf2tutorialEntities db = new zf2tutorialEntities();
            var Album = db.albums.ToList();
            Console.BackgroundColor = ConsoleColor.Blue;
            foreach (var item in Album)
            {
                Console.WriteLine("Album id is \t" + item.id + "\tArtist Name\t" + item.artist + "\tTitle is \t" + item.title);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadLine();
        }
    }
}
