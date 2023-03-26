using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD6_1302210084
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random rnd = new Random();
            this.title = title;
            this.playCount = 0;
            this.id = rnd.Next(10000, 100000);
        }
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Id video "+this.id+" dengan judul "+this.title+" memiliki jumlah viewer "+ this.playCount);
        }
    }
}
