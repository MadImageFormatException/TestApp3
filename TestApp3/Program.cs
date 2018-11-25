using System;
using TestLibrary1;

namespace TestApp3
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( Helper.GetTime() + " - Hello!" );
			Console.ReadKey();
		}
	}
}
