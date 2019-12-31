using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			 Console.WriteLine("donner le nombre des élèves");
			var n = int.Parse(Console.ReadLine());
			int i = 0;
			var names = new string[n] ;
			var grades = new int[n] ;
			while (i < n)
			{
				Console.WriteLine("donner le nom d'élève");
				var name = Console.ReadLine();
				Console.WriteLine("give his grade ");
				var grade = int.Parse(Console.ReadLine());
				names[i] = name;
				grades[i] = grade;
				i++;
			}
			for (int j = 0; j <= n; j++)
			{
				Console.WriteLine("student :" + names[j] + " grade :" + grades[j]);
			}


		}

			
	}
}
