using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest3
{
	internal class Lamp
	{
		Switcher switcher;

		public Lamp(Switcher switcher)
		{
			this.switcher = switcher;

			switcher.switched += On;
		}

		public void On(object sender, bool on)
		{
			Switcher? switcher = sender as Switcher;
			if (on)
				Console.WriteLine("Lamp On");
			else
				Console.WriteLine("Lamp Off");
		}
	}
}