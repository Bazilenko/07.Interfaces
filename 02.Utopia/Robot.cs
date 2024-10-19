using System;

public class Robot : IPerson
{
	string model;
	string id;

	public Robot(string model, string id)
	{
		Model = model;
		Id = id;

	}
	public Robot() { }
	public string Id {  get { return id; } 
		set { id = value; }
	}
	public void Check(string id)
	{
        if (Id.EndsWith(id))
        {
            Console.WriteLine(Id);
        }

    }
	public string Model { get; set; }
	
	
}
