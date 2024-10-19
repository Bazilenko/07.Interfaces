using System;
class Program
{
    static void Main()
    {
        MenuForCheckFake();
        MenuForBirthday();
        MenuForFood();
    }
    static void MenuForCheckFake()
    {
        Console.WriteLine("Check for fake");
        List<string> Id = new List<string>();
        List<Robot> robots = new List<Robot>();
        List<Citizen> citizens = new List<Citizen>();
        string fake;
        string command = "";
        string[] commands = { "" };
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");
            string id = commands[commands.Length - 1];
            Id.Add(id);
            if (commands.Length == 2)
            {
                Robot robot = new Robot(commands[0], commands[1]);
                robots.Add(robot);
            }
            else if (commands.Length == 3)
            {
                Citizen citizen = new Citizen(commands[0], int.Parse(commands[1]), commands[2]);
                citizens.Add(citizen);
            }
        }
        fake = Console.ReadLine();
        for (int i = 0; i < Id.Count; i++)
        {
            if (Id[i].EndsWith(fake))
                Console.WriteLine(Id[i]);
        }
    }
    static void MenuForBirthday()
    {
        Console.WriteLine("Birthday menu:");
        string[] commands = { "" };
        string date;
        List<string> birtdays = new List<string>();
        List<Robot> robots = new List<Robot>();
        List<Pet> pets = new List<Pet>();
        List<Citizen> citizens = new List<Citizen>();
        string command = "";
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");
            if (commands.Length == 4)
            {
                Citizen citizen = new Citizen(commands[0], int.Parse(commands[1]), commands[2], commands[3]);
                birtdays.Add(commands[3]);
            }
            else if (commands[1].Contains("/"))
            {
                Pet pet = new Pet(commands[0], commands[1]);
                birtdays.Add(commands[1]);
            }
            else
            {
                Robot robot = new Robot(commands[0], commands[1]);
            }
        }
        date = Console.ReadLine();
        bool exist = false;
        for (int i = 0; i < birtdays.Count; i++)
        {
            if (birtdays[i].Contains(date))
                exist = true;
            Console.WriteLine(birtdays[i]);
        }
        if (!exist)
            Console.WriteLine("empty output");
    }

    static void MenuForFood()
    {
        string command = "";
        string[] commands = { "" };
        int food = 0;
        List<Rebel> rebels = new List<Rebel>();
        List<Citizen> citizens = new List<Citizen>();

        int N;
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            commands = command.Split(" ");
            if (commands.Length == 3)
            {
                Rebel rebel = new Rebel(commands[0], int.Parse(commands[1]), commands[2]);
                rebels.Add(rebel);

            }
            else
            {
                Citizen citizen = new Citizen(commands[0], int.Parse(commands[1]), commands[2], commands[3]);
                citizens.Add(citizen);
            }
        }
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");
            for (int i = 0; i < N; i++)
            {
                if (rebels[i].Name == command)
                {
                    rebels[i].BuyFood();
                    food += rebels[i].Food;
                }
                else if (citizens[i].Name == command)
                {
                    citizens[i].BuyFood();
                    food += citizens[i].Food;
                }
            }


        }
        Console.WriteLine(food);

    }
}
