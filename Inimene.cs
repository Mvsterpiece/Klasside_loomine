using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_loomine
{
	class Inimene
	{
		public string perenimi;
		public string staatus;
		int vanus;
		public int Palk;
		public Inimene() { }
		public Inimene(string Perenimi)
		{
			perenimi = Perenimi;
		}
		public string Perenimi
		{
			set { if (perenimi == null) perenimi = value; }
			get { return perenimi; }
		}
		public int Vanus
		{
			set
			{
				vanus = value;
				if (vanus<7)
				{
					staatus = "Laps";
				}
				else if (vanus<17)
				{
					staatus = "koolilaps";
				}
				else if (vanus<24)
				{
					staatus = "ülikoolilaps";
				}
				else
				{
					staatus = "tööline";
				}
			}
			get { return vanus; }

		}
		public string Staatus
		{
			get { return staatus; }
		}
		public void Tervitamine()
		{
			Console.WriteLine("Minu perenimi on "+ perenimi);
			Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, staatus);
		}
	}
}
