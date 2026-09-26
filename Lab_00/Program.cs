namespace Lab_00;

class Program
{
    public static void Main()
    {
        // юзер игрока
        Console.WriteLine("Welcome to *game name*! What's your username?");
        string username = Console.ReadLine();

        //  почта
        Console.WriteLine('\n');
        Console.Write("your email address: ");
        string email = Console.ReadLine();

        // дата рождения
        Console.WriteLine('\n');
        Console.Write("Your birthday (numbers): ");
        string bd = Console.ReadLine();


        // номер телефона
        Console.WriteLine('\n');
        Console.WriteLine("your phone number (9 digits): ");
        Console.Write("+7");
        string number = Console.ReadLine();
        //Console.WriteLine($"+7{number}");

        // пол
        Console.WriteLine('\n');
        Console.WriteLine("Gender (optioanl)");
        Console.WriteLine("- Male, \n- Female, \n- Other");
        string gender = Console.ReadLine();

        // pronouce
        Console.WriteLine('\n');
        Console.Write("What are your pronouce? \n(example: he/him): \n");
        string pronouce = Console.ReadLine();


        // Итог

        Console.WriteLine('\n');
        Console.WriteLine("Check your information for any mistakes");
        Console.WriteLine("\n\t" + "<<" + username + ">>");

        Console.WriteLine('\n');
        Console.WriteLine($"Birthday: {bd}");

        Console.WriteLine($"\nGender and pronouce: \n- {gender}");
        Console.WriteLine("- " + pronouce);

        Console.WriteLine($"\nemail: {email}");
        Console.WriteLine($"phone number: +7{number}");
    }
}