using System.Diagnostics.Contracts;
using TP_MOD6_1302210084;

SayaTubeVideo obj1 = new SayaTubeVideo("Tutorial Design By Contract – [SURYA AULIA]");
obj1.IncreasePlayCount(500000);
obj1.PrintVideoDetails();

SayaTubeVideo obj2 = new SayaTubeVideo("FaZe vs Cloud9 - ESL Pro League Season 17 - Grand Final");
for (int i = 0; i < 500; i++)
{
    obj2.IncreasePlayCount(10000000);
}
obj2.PrintVideoDetails();