using System;

public interface IBrowser
{
    void Browse(string site = "Browsing...")
    {
        Console.WriteLine(site);
    }
}
