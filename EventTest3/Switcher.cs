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
		public event SwitchOnHandler switched;

		public virtual void OnSwitchChanged(object sender, bool on) { }

		public Switcher()
		{
			switched += OnSwitchChanged;
		}

		public void SwitchOn()
		{
			switched(this, true);
		}

		public void SwitchOff()
		{
			switched(this, false);
		}
	}
}