using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest3
{
	delegate void SwitchOnHandler(object sender, bool on);

	internal class Switcher
	{
		ISwitchable switchable;

		public Switcher(ISwitchable switchable)
		{
			this.switchable = switchable;
		}

		public void SwitchOn()
		{
			switchable.SwitchOn();
		}

		public void SwitchOff()
		{
			switchable.SwitchOff();
		}
	}
}