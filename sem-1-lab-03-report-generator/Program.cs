using System.Globalization;
namespace sem_1_lab_03_report_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("event_server.log");
            string report = BuildReport(lines);
            Console.WriteLine(report);
        }
        public static string BuildReport(string[] lines)
        {
            DateTime date = GetDate(lines);
            string winner = GetWinner(lines);
            int points = GetPoints(lines);
            string item = GetItem(lines);
            int points1 = GetLoser(lines);
            int warnings = GetWarning(lines);
            int errors = GetErr(lines);

            string report = $"# Итоги события: Восстание Ледяного Пламени\n\n" +
                            $"Дата: {date:dd.MM.yyyy}\n" +
                            $"Победитель: {winner}\n" +
                            $"Очки победителя: {points}\n" +
                            $"Ивентовый предмет: {item}\n" +
                            $"Утешительная награда Железных волков: {points1} очков\n" +
                            $"Предупреждений во время события: {warnings}\n" +
                            $"Ошибок во время события: {errors}";

            return report;
        }

        public static DateTime GetDate(string[] lines)
        {
            foreach (string line in lines)
            {
                if (line.Contains("Событие началось:"))
                {
                    string ymd = line.Substring(0, 10);
                    DateTime date = DateTime.ParseExact(ymd, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    return date;

                }
            }
            return DateTime.MinValue;
        }
        public static string GetWinner(string[] lines)
        {
            foreach (string line in lines)
            {
                if (line.Contains(" объявлены победителями события"))
                {
                    int messageStart = line.IndexOf("] ") + 2;
                    int winnerEnd = line.IndexOf(" объявлены победителями");
                    string winner = line.Substring(messageStart, winnerEnd - messageStart);
                    return winner;
                }

            }
            return "";
        }
        public static int GetPoints(string[] lines)
        {

            foreach (string line in lines)
            {
                if (line.Contains("Ночные совы получили ") && line.Contains(" очков события"))
                {
                    const string startText = "Ночные совы получили ";
                    int start = line.IndexOf(startText) + startText.Length;
                    int end = line.IndexOf(" очков", start);
                    int points = int.Parse(line.Substring(start, end - start));
                    return points;
                }
            }
            return 0;
        }

        public static string GetItem(string[] lines)
        {
            foreach(string line in lines)
            {
                if (line.Contains("Ночные совы получили ивентовый предмет: "))
                {
                    int messageStart = line.IndexOf("] ") + 2;
                    int itemStart = line.IndexOf("ивентовый предмет: ") + "ивентовый предмет: ".Length;
                    string item = line.Substring(itemStart);
                    return item;
                }
            }
            return "";
        }

        public static int GetLoser(string[] lines)
        {
            foreach(string line in lines)
            {
                if (line.Contains("Железные волки получили утешительную награду: "))
                {
                    const string startText = "Железные волки получили утешительную награду: ";
                    int start = line.IndexOf(startText) + startText.Length;
                    int end = line.IndexOf(" очков события", start);
                    int points1 = int.Parse(line.Substring(start, end - start));
                    return points1;
                }

            }
             
            return 0;
        }

        public static int GetWarning(string[] lines)
        {

            bool isEventRunning = false;
            int cnt = 0;

            foreach (string line in lines)
            {
                if (line.Contains("Событие началось:"))
                {
                    isEventRunning = true;
                    continue;
                }

                if (line.Contains("Событие \"Восстание Ледяного Пламени\" закрыто"))
                {
                    isEventRunning = false;
                    continue;
                }

                if (isEventRunning)
                {
                    if (line.Contains("Warning"))
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
            
        }
        public static int GetErr(string[] lines)
        {
            bool isEventRunning = false;
            int cnt1 = 0;
            foreach(string line in lines)
            {
                if (line.Contains("Событие началось:"))
                {
                    isEventRunning = true;
                    continue;
                }
                if (line.Contains("Событие \"Восстание Ледяного Пламени\" закрыто"))
                {
                    isEventRunning = false;
                    continue;
                }
                if (isEventRunning)
                {
                    if (line.Contains("Error"))
                    {
                        cnt1++;
                    }
                }
            }
            return cnt1;
        }
    }
}