namespace EventTest3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Switcher switcher = new Switcher();
		
			Lamp lamp = new Lamp(switcher);

			switcher.SwitchOff();
		}
	}
}