using System;

namespace MakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the current temperature: ");
            //int temp = Convert.ToInt32(Console.ReadLine());
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnterANumber = int.TryParse(temperature, out number);

            if(userEnterANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Please enter an interger");
            }

            if (numTemp < 70)
            {
                Console.WriteLine("Wear a jacket or coat");
            }
            else if (numTemp == 70)
            {
                Console.WriteLine("Perfect weather");
            }
            else
            {
                Console.WriteLine("No jacket or coat necessary");
            }

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();

            if (isRegistered && userName !="" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi registered user");
                Console.WriteLine("Hi {0}", userName);
                Console.WriteLine("Hi Admin");
            }
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Write("Please register your login name: ");
            string registerName = Console.ReadLine();
            Console.Write("Please create a password: ");
            string newPassword = Console.ReadLine();
            Console.WriteLine("Please login");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            if (registerName.Equals(username) && newPassword.Equals(password))
            {
                Console.WriteLine("Welcome {0}, you are now logged in", username);
            }
            else
            {
                Console.WriteLine("Please try again");
            }
            Register();
            Login();

            int aged;
            Console.WriteLine("Are you 15 or 25?");
            bool age = int.TryParse(Console.ReadLine(), out aged); 
            switch (aged)
            {
                case 15:
                    Console.WriteLine("To young to drive");
                    break;
                case 25:
                    Console.WriteLine("Car insurance deduction");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            string login;
            Console.WriteLine("Please enter your login name");
            login = Console.ReadLine();
            switch (login)
            {
                case "mcanty":
                    Console.WriteLine("Login name {0} is now logged in", login);
                    break;

                case "admin":
                    Console.WriteLine("Login name is now logged in as admin");
                    break;

                default:
                    Console.WriteLine("unknown login name");
                    break;
            }
            Score(1200, "Marcus");

            int waterTemp = 14;
            string waterStateOfMatter;
            waterStateOfMatter = waterTemp > 212 ? "gas" : waterTemp <  32 ? "solid": "liquid";
            Console.WriteLine("At {0} degrees water state of matter = {1}", waterTemp, waterStateOfMatter);
            waterTemp += 100;
            waterStateOfMatter = waterTemp > 212 ? "gas" : waterTemp < 32 ? "solid" : "liquid";
            Console.WriteLine("At {0} degrees water state of matter = {1}", waterTemp, waterStateOfMatter);
            waterTemp += 100;
            waterStateOfMatter = waterTemp > 212 ? "gas" : waterTemp < 32 ? "solid" : "liquid";
            Console.WriteLine("At {0} degrees water state of matter = {1}", waterTemp, waterStateOfMatter);

            Console.WriteLine("Please enter the temperature");
            string thermometer = (Console.ReadLine());
            string printOut = string.Empty;
            bool result = int.TryParse(thermometer, out int readout);
            if (result)
            {
                printOut = readout > 80 ? "it's hot" : readout <= 60 ? "it's too cold" : "it's just right";
                Console.WriteLine(printOut);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }

        static string username;
        static string password;
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("--------------------------------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter our password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Please try again.");
            }
        }
        //static int score;
        static string highscorePlayer = "Crosstown";
        static int highScore = 1500;
        public static void Score(int score, string playerName)
        {
            //Console.WriteLine("Please enter your player name");
            //string playerName = Console.ReadLine();
            //Console.WriteLine("Please enter your score: ");
            //score = int.Parse(Console.ReadLine());
            if (score > highScore)
            {
                highScore = score;
                highscorePlayer = playerName;
                Console.WriteLine("{0} is the new highscore holder with a score of: {1}", playerName, highScore);    
            }
            else
            {
                Console.WriteLine("{0} highscore of {1} could not be beat", highscorePlayer, highScore);
            }
        }
    }
}
