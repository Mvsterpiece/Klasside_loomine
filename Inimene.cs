using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_loomine
{
	class Inimene
	{
		public string eesnimi;
		public string perenimi;
		public string staatus;
		int vanus;
		int palk;
		public string money;
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
		public string Eesnimi
		{
			set { if (eesnimi == null) eesnimi = value; }
			get { return eesnimi; }
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
			Console.WriteLine("Minu eesnimi on "+ eesnimi+" ja perekonnanimi "+perenimi);
			Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, staatus);
			Console.WriteLine("Ja olen {0}",money);
		}
		public int Palk
		{
			set
			{
				palk = value;
				if (palk < 500)
				{
					money = "Poor";
				}
				else if (palk < 1000)
				{
					money = "Close to be poor";
				}
				else if (palk < 1500)
				{
					money = "Nice salary";
				}
				else
				{
					money = "Who are you?";
				}
			}
			get { return palk; }
		}
		public string Money
		{
			get { return money; }
		}
	}
}
