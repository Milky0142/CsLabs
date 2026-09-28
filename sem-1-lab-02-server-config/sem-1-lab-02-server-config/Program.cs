namespace sem_1_lab_02_server_config
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("<<<Starting server configuration....>>>");

            // player count
            Console.WriteLine("- How many players are online?");
            if (!int.TryParse(Console.ReadLine(), out int players))
            {
                Console.WriteLine("<<Incorrect input>>"); return;
            }
            if (players > 50)
            {
                Console.WriteLine("<<<Server launch is impossible! Max player count reached>>>"); return;
            }
            if (players <= 0)
            {
                Console.WriteLine("<<<Server launch is impossible! The server has no players online, come back later.>>>"); return;
            }


            // memory
            Console.WriteLine("- How much RAM memory is available(GB)?");
            if (!int.TryParse(Console.ReadLine(), out int mem))
            {
                Console.WriteLine("<<Incorrect input>>"); return;
            }
            if (mem < 4)
            {
                Console.WriteLine($"<<<Server launch is impossible! {mem} is not enough to play on the server.>>>"); return;
            }
        

            // sps
            Console.WriteLine("- Turn on 'Security Protection System'? Y/N");
            string sps = Console.ReadLine().ToUpper();
            if (sps == "Y")
            {
                Console.WriteLine("\n<<<Initiating 'Security Protection System'....>>>\n");
            }
            else if (sps == "N")
            {
                Console.WriteLine("\n<<<Warning! 'Security Protection System' is off>>>\n");
            }
            else
            {
                Console.WriteLine("<<Incorrect input.>>"); return;
            }
           

            // public server or not
            Console.WriteLine("- Is the server public? Y/N");
            string server = Console.ReadLine().ToUpper();
            if (server == "Y")
            {
                Console.WriteLine("\n<<<The server is public, access granted....>>>\n");
            }
            else if (server == "N")
            {
                Console.WriteLine("<<<Server launch is impossible! The server is set as private, access denied.>>>"); return;
            }
            else
            {
                Console.WriteLine("<<Incorrect input.>>"); return;
            }


            // ban
            Console.WriteLine("- Are you banned from this server? Y/N");
            string ban = Console.ReadLine().ToUpper();
            if (ban == "Y")
            {
                Console.WriteLine("<<<Server launch is impossible! You are banned.>>>"); return;
            }
            else if (ban == "N")
            {
                Console.WriteLine("\n<<<No bans detected....>>>\n");
            }
            else
            {
                Console.WriteLine("<<Incorrect input.>>"); return;
            }


            Console.WriteLine("___The server is ready to launch!___");
        }
    }
}
