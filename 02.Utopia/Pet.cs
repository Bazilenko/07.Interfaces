using System;

interface IBirthday
{
	string DateBirth { get; set; }
}
public class Pet : IBirthday
{
	string name;
	string dateBirth;
	public string DateBirth
	{get; set;}
	public string Name
	{ get; set;}
	
	public Pet(string name, string dateBirth)
	{
		Name = name;
		DateBirth = dateBirth;
	}
	
	public Pet() { }
}
