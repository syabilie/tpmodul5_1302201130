using System;
using System.Diagnostics.Contracts;

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
			Contract.Requires(title != null);
			Contract.Requires(title.Length <= 100);
			this.title = title;

			var random = new Random();
			id = random.Next(10000, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int jum)
		{
			Contract.Requires(jum <= 1000000);
			try
			{
				if (jum > 10000000) throw new Exception("Input play count melebihi batas maksimal!");
				this.playCount = checked(this.playCount + jum);
			}
			catch (Exception a)
			{
				Console.WriteLine(a.Message);
			}

		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("====Video Details====");
			Console.WriteLine("ID : " + this.id);
			Console.WriteLine("Title : " + this.title);
			Console.WriteLine("Play Count : " + this.playCount);
			Console.WriteLine();
		}

	}
}
