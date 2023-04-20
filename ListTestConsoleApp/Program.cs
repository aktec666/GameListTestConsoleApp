List<string?> games = new List<string?>() { "CS:GO", "GTA 5", "Dota"};
List<string?> commands = new List<string?> { "выход", "команды", "добавить", "вывести", "изменить", "удалить" };



void PrintCommands()
{
    Console.WriteLine("Выберите команду из списка");
    for (int i = 0; i < commands.Count; i++)
        Console.WriteLine($"{commands[i]}");
}

void Print()
{
    for (int i = 0; i < games.Count; i++)
        Console.WriteLine($"{i} : {games[i]}");
}

void Append()
{
    Console.WriteLine("Какую игру добавить?");
    string? game = Console.ReadLine();
    games.Add(game);
}

void Update()
{
    Console.WriteLine("Какой номер игры изменить?");
    string? number = Console.ReadLine();
    Console.WriteLine("На какую игру изменить?");
    string? game = Console.ReadLine();
    games[Convert.ToInt32(number)] = game;
}

void Delete()
{
    Console.WriteLine("С каким номером удалить игру?");
    string? number = Console.ReadLine();
    games.RemoveAt(Convert.ToInt32(number));
}


PrintCommands();
while (true)
{
    string? command = Console.ReadLine();
    if (command == "добавить")
        Append();
    else if (command == "вывести")
        Print();
    else if (command == "изменить")
        Update();
    else if (command == "удалить")
        Delete();
    else if (command == "команды")
        PrintCommands();
    else if (command == "выход")
        break;
}