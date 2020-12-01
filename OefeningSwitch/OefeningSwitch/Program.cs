using System;

namespace OefeningSwitch
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("Geef de waarde van X (geheel getal):");
			int x = int.Parse(Console.ReadLine());
			if (x == 1)
			{
				Console.WriteLine("X is één waard.");
			}
			else if (x == 2)
			{
				Console.WriteLine(" X is twee waard.");
			}
			else if (x == 3)
			{
				Console.WriteLine(" X is drie waard.");
			}
			else if (x == 4)
			{
				Console.WriteLine(" X is vier waard.");
			}
			else if (x == 5)
			{
				Console.WriteLine(" X is vijf waard.");
			}
			else if (x == 6)
			{
				Console.WriteLine(" X is zes waard.");
			}
			else if (x == 7)
			{
				Console.WriteLine(" X is zeven waard.");
			}
			else if (x == 8)
			{
				Console.WriteLine(" X is acht waard.");
			}
			else if (x == 9)
			{
				Console.WriteLine(" X is negen waard.");
			}
			else if (x == 10)
			{
				Console.WriteLine(" X is tien waard.");
			}
			else
			{
				Console.WriteLine(" X is meer dan tien of minder dan 1 waard.");
			}
		}
	}
  }
