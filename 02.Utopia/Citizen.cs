using System;

public class Citizen : IPerson, IBirthday, IBuyer
{
	string id;
    string name;
    int age;
    string dateBirth;
    int food = 0;
	public Citizen(string name, int age, string id, string dateBirth = "/")
	{
        Name = name;
        Age = age;
        Id = id;
        DateBirth = dateBirth;
	}
    public string DateBirth {  get; set;  }
    public int Food { get; set; }
    public void Check(string id)
    {
        if (Id.EndsWith(id))
        {
            Console.WriteLine(Id);
        }
    }
    public void BuyFood()
    {
        Food += 10;
    }
    public string Id { get { return id; }
		set { id = value; }
	}
    public string Name { get; set; }
    public int Age { get; set; }
	
}
