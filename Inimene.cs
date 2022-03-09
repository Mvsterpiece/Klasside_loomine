using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_loomine
{
	public abstract class Inimene
	{
		public string eesnimi;
		public string perenimi;
		public string staatus;
		int vanus;
		int palk;
		Emakeel emakeel;
		public string money;
		public Inimene() { }
		public Inimene(string Perenimi, Emakeel emakeel)
		{
			perenimi = Perenimi;
			this.emakeel = emakeel;
		}
		public Inimene(string Perenimi, string Eesnimi)
		{
			perenimi = Perenimi;
			eesnimi = Eesnimi;
		}
		public Emakeel Emakeel
		{
			get { return emakeel; }
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
			}
			get { return vanus; }
		}
		public string Staatus
		{
			get {
				if (vanus < 7)
				{
					staatus = "Laps";
				}
				else if (vanus < 17)
				{
					staatus = "koolilaps";
				}
				else if (vanus < 24)
				{
					staatus = "ülikoolilaps";
				}
				else
				{
					staatus = "tööline";
				}
				return staatus; }
		}
		public void Tervitamine()
		{
			if (perenimi!=null && eesnimi!=null)
			{
				Console.WriteLine("Minu eesnimi on {0} ja perekonnanimi {1} ", eesnimi, perenimi);
			}
			else if (perenimi==null && eesnimi != null)
			{
				Console.WriteLine("Minu perekonnanimi on"+perenimi);
			}
			else if (eesnimi==null && perenimi != null)
			{
				Console.WriteLine("Minu eesnimi on" + eesnimi);
			}
			else
			{
				Console.WriteLine("Tere! Sõber");
			}
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
		public double Sootsiaalne()
		{
			double sots = 0;
			sots = Palk * 0.33;
			return sots;
		}
		public abstract void Kes_ma_olen();
	}
}
