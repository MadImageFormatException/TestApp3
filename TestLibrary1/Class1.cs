using System;

namespace TestLibrary1
{
	public class Helper
	{
		public static string GetTime()
		{
			var now = DateTime.Now;
			return $"{now.Year:D4}-{now.Month:D2}-{now.Day}~{now.Hour:D2}-{now.Minute:D2}-{now.Second:D2}";
		}
	}
}
