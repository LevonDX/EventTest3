using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest3
{
	internal class Lamp : ISwitchable
	{
		public void SwitchOn()
		{
			Console.WriteLine("Lamp is on");
		}

		public void SwitchOff()
		{
			Console.WriteLine("Lamp is off");
		}
	}

	class Diod : ISwitchable
	{
		public void SwitchOn()
		{
			Console.WriteLine("Diod is on");
		}

		public void SwitchOff()
		{
			Console.WriteLine("Diod is off");
		}
	}
}