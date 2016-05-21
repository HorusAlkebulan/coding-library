using System;

namespace Coding.LinkedLists
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Coding.LinkedLists");
			
			RunTests();
		}

		public static void RunTests() {
			// build a list from 1 to 5
			// print the list

			LinkedList<int> list = new LinkedList<int> ();
			
			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);
			list.Add(5);
			
			Console.WriteLine("List Contents: {0}", list.ToString());

			// remove the 3rd item

			// reverse the list
		}
	}
}
