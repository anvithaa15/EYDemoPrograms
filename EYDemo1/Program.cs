//Basic programs in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYDemo1
{
	class Program
	{
		static void Main(string[] args)
		{
			//int a1 = 10;
			//float a2 = 10.26543f;
			//char ch = 'a';
			//string s1 = "EY GDS";
			//Console.WriteLine("Hello world");
			//Console.WriteLine(a1);
			//Console.WriteLine(a2);
			//Console.Write(s1);
			//Console.ReadKey();

			Console.WriteLine("enter your name");
			string name = Console.ReadLine();
			Console.WriteLine("enter your roll num");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("name: " + name);
			Console.WriteLine("roll num: " + num);
			Console.ReadLine();


			Console.WriteLine("enter 1st number:");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("enter 2nd number:");
			int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Addition value is :" + (num1 + num2));
			Console.WriteLine("Multiplication value is :" + (num1 * num2));
			Console.WriteLine("Division value is :" + (num1 / num2));
			Console.ReadLine();



			int a = int.Parse(Console.ReadLine());
			int i = int.Parse(Console.ReadLine());
			int t = int.Parse(Console.ReadLine());
			Console.WriteLine("SIMPLE INTREST :  " + (a * i * t / 100));
			Console.ReadLine();

		}
	}
}

