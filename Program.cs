using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_loomine
{
	class Program
	{
		static void Main(string[] args)
		{
			Inimene naine = new Inimene("Kask");
			Console.WriteLine("Kui vana sa oled?");
			naine.Vanus = int.Parse(Console.ReadLine());
			naine.Tervitamine();
			Inimene mees = new Inimene();
			mees.Perenimi = "Shakur";
			mees.Vanus = 45;
			Console.WriteLine(mees.Perenimi+" on "+mees.Vanus +" aastane mees");
			mees.Tervitamine();

			Inimene[] inimesed = new Inimene[2];
			for (int i = 0; i < 2; i++)
			{
				inimesed[i] = new Inimene();
				Console.WriteLine("Mis on sinu eesnimi?");
				inimesed[i].Eesnimi = Console.ReadLine();
				Console.WriteLine("Mis on sinu perekonnanimi?");
				inimesed[i].Perenimi = Console.ReadLine();
				Console.WriteLine("Kui vana sa oled?");
				inimesed[i].Vanus = int.Parse(Console.ReadLine());
				Console.WriteLine("kui palju raha sa saad kuus?");
				inimesed[i].Palk = int.Parse(Console.ReadLine());
			}
			foreach (Inimene inimene in inimesed)
			{
				inimene.Tervitamine();
			}


			Console.ReadLine();
		}
	}
}
