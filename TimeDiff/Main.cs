using System;

namespace TimeDiff
{
	class MainClass
	{
		public static TimeSpan ParseSpan (string input)
		{
			string[] splited = input.Trim().Split(':');
			int hours = int.Parse(splited[0].Trim());
			int minutes = int.Parse(splited[1].Trim());

			return new TimeSpan(hours, minutes, 0);
		}

		public static void Main (string[] args)
		{
			TimeSpan total = new TimeSpan(0, 0, 0);
			foreach (var arg in args) {
				string[] splitted = arg.Trim().Split('-');

				TimeSpan span1 = ParseSpan(splitted[0].Trim());
				TimeSpan span2 = ParseSpan(splitted[1].Trim());
				TimeSpan diff = span2 - span1;
				total += diff;

				Console.WriteLine(string.Format("{0} -> {1}:{2}", arg, diff.Hours.ToString("00"), diff.Minutes.ToString("00")));
			}

			Console.WriteLine("Total: " + total.Hours.ToString("00") + ":" + total.Minutes.ToString("00"));
		}
	}
}
