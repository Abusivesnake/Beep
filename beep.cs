using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Program
{
	class Beep
	{
		public static void Main(string[] args)
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				Console.Beep();
			}
		}
	}
}
