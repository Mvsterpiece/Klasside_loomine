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
			Inimene i = new Opilane("Anna", "Tamm", "TARpe21");
			i.Kes_ma_olen();
			i.Tervitamine();
			Inimene[] inim = new Inimene[4];
			inim[0] = new Opetaja();
			inim[0].Kes_ma_olen();
			inim[1] = new Opilane();
			inim[1].Kes_ma_olen();
			inim[2] = new Opetaja();
			inim[2].Kes_ma_olen();
			inim[3] = new Opilane();
			inim[3].Kes_ma_olen();

			/*Opilane opilane = new Opilane();
			opilane.Eesnimi = "Denis";
			opilane.Perenimi = "Saiko";
			opilane.Hinne = 4;
			opilane.Informatsioon();
			Inimene naine = new Inimene();
			naine.Palk = 100;
			double s = naine.Sootsiaalne();
			Console.WriteLine(s);
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
			}*/
			Console.ReadLine();
		}
	}
}
