using System;

public class Smartphone : ICall, IBrowser
{
	
	public Smartphone(){}
	public void Browse(string site)
	{
        for (int i = 0; i < site.Length; i++)
        {
            if (Char.IsDigit(site[i]))
                throw new ArgumentException("Invalid URL, cannot include digits!");
        }
		Console.WriteLine("Browsing... {0}", site);
    }
	public void Call(string number)
	{
		for (int i = 0; i < number.Length; i++)
		{
			if (!Char.IsDigit(number[i]))
				throw new ArgumentException("Invalid number!");
		}
		Console.WriteLine("Calling... {0}", number);
	}
	
}
