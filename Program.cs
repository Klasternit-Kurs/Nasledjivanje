using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class Program
	{
		static void Main(string[] args)
		{
			Primer p = new Primer(6, "asd");


			object o = new object();
			int a = 5;
			Nesto x = new Nesto("asdasdasd", 5);
		}
	}

	class Primer
	{
		public int Broj;

		public Primer(int i, string nn)
		{
			Broj = i;
		}
	}

	class Nesto : Primer
	{
		public string Test;
		public Nesto(string t, int n) : base(n, "asd")
		{
			Test = t;
		}
	}
}
