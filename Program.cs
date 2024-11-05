namespace StopWatch;

class Program
{
    static void Main(string[] args)
    {

        Menu();
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go!");
        Thread.Sleep(1000);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("StopWatch Finalizado! Retornando para o menu...");
        Thread.Sleep(2000);
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Quanto tempo deseja contar?");
        Console.WriteLine("");
        Console.WriteLine("Contar em SEGUNDOS: ");
        Console.WriteLine("Inserir a quantidade seguido da letra 's' (Por exemplo: 10s)");
        Console.WriteLine("");
        Console.WriteLine("Contar em MINUTOS: ");
        Console.WriteLine("Inserir a quantidade seguido da letra 'm' (Por exemplo: 10m)");
        Console.WriteLine("");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;
        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);
    }
}
