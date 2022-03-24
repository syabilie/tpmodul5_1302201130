using System;

namespace tpmodul5_1302201130
{
    public class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Syabila Ilma Elsani");
            video.IncreasePlayCount(50);
            video.PrintVideoDetails();

            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

            video.IncreasePlayCount(50000000);
            video.PrintVideoDetails();
        }
    }
}
