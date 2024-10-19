using System;
class Program
{
    static void Main()
    {
        Menu();

    }

    static void Menu()
    {
        string[] commands = { "" };
        string command = "";
        Smartphone smartphone = new Smartphone();
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");

            for (int i = 0; i < commands.Length - 1; i++)
            {
                try
                {
                    int num;
                    if (int.TryParse(commands[i], out num))
                        smartphone.Call(commands[i]);
                    else
                        smartphone.Browse(commands[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}