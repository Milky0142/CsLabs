namespace Laba_1;

class Program
{
    public static void Main()
    {
        // начало + приветсвие тест1
        Console.WriteLine("Loading data.....");
        Console.WriteLine("Starting up the server....");
        Console.WriteLine("");
        Console.WriteLine("Welcome to \"BlagoMax\" server!");
        Console.WriteLine("");

        Console.WriteLine("Please enter login and password:");
        Console.WriteLine("");
        Console.WriteLine("Login: ");
        string user_name = Console.ReadLine();

        Console.WriteLine("Password: ");
        string password = Console.ReadLine();
        long pass = int.Parse(password);
        Console.WriteLine("");

        Console.WriteLine($"Welcome, {user_name}!");
        Console.WriteLine("");
        Console.WriteLine("User statistics...");
        Console.WriteLine("");




        // данные

        string buffer = "21343";
        int player_count = Convert.ToInt32(buffer);
        int hours = 127;
        short activity = 32;
        byte level = 77;
        string display_name = "WArriorXXXX";
        double mem = 2531.79;
        double cpu = 11.85;
        double gpu = 12.06;
        decimal ping = 58;




        // вывод статистики игрока
        Console.WriteLine("");
        DateTime current_time = DateTime.Now;
        Console.WriteLine($"Login time: {current_time}");
        Console.WriteLine("");
        Console.WriteLine("User name: " + display_name);
        Console.WriteLine("- Last seen: " + activity + " day(s) ago");
        Console.WriteLine("- Total hours played: " + hours + " h");
        Console.WriteLine($"- Curent level: {level} lvl");


        // вывод статистики сервера
        Console.WriteLine("\n\nServer statistics....");
        Console.WriteLine("\nMemory: " + mem + " MB");
        Console.WriteLine($"CPU: {cpu} ms");
        Console.WriteLine($"GPU: {gpu} ms");
        Console.WriteLine($"NetworkPing: {ping} ms");
        Console.WriteLine("Registered online player count: " + player_count);
    }
}