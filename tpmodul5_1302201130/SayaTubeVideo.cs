using System;

namespace tpmodul5_1302201130
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;
		public SayaTubeVideo() { }

		public SayaTubeVideo(string title)
		{
			this.title = title;

			var random = new Random();
			id = random.Next(10000, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int jum)
		{

		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("====Video Details====");
			Console.WriteLine("ID : " + this.id);
			Console.WriteLine("Title : " + this.title);
			Console.WriteLine("Playcount : " + this.playCount);
		}

	}
}
