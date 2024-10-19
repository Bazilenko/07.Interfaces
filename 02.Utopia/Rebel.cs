using System;

public class Rebel : IBuyer
{
    string name;
    int age;
    string group;
    int food = 0;
    public Rebel() { }
    public Rebel(string name, int age, string group)
	{
        Name = name;
        Age = age;
        Group = group;		
	}
    public void BuyFood()
    {
        Food += 5;
    }
    public int Food { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
}
