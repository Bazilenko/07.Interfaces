using System;

public interface ICall
{
    void Call(string number = "Calling...") 
    { 
        Console.WriteLine(number);
    }
}
