using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Drawing;
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
            Debug.Assert(title != null && title.Length <= 100, "judul yang dimasukan lebih dari 100 karakter atau kosong");
            Random rnd = new Random();
            try
            {
                this.title = checked(title);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            playCount = 0;
            id = rnd.Next(10000, 100000);
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount < 10000000);

            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id video "+this.id+" dengan judul "+this.title+" memiliki jumlah viewers "+ this.playCount);
        }
    }
}
