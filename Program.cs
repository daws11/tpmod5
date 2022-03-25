using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace tpmodul5_1302204070
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo tube = new SayaTubeVideo("tutorial...");
            tube.PrintVideoDetails();
            tube.IncreasePlayCount(1);
            tube.PrintVideoDetails();
        }

    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judul)
        {
            //contract no5
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
            Random ids = new Random();
            this.title = judul;
            id = ids.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            //trycatch no5
            try
            {
                if (i >= 10000000) throw new Exception("angka melebihi batas");
                playCount = playCount + i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            playCount = playCount + i;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.playCount);
        }
    }
}
