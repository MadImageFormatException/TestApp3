using System;
using TestLibrary1;

namespace TestApp3
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( Helper.GetTimeStamp() + " - Hello!" );
			Console.ReadKey();
		}
	}
}
