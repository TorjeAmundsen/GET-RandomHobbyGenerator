namespace HobbyGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomHobby();
        }
        static void RandomHobby()
        {
            string[] hobbies = {
                " is now a sorcerer!",
                " is now a professional artist!",
                " is now a football player.",
                " has become a rock climber!"
            };
            Console.WriteLine("Who would like a new hobby?");
            string name = Console.ReadLine();
            Random rng = new Random();
            int randomIndex = rng.Next(0, hobbies.Length);
            string randomHobby = hobbies[randomIndex];
            Console.WriteLine(name + randomHobby);
            StartOver();
        }
        static void StartOver()
        {
            Console.WriteLine("Would you like to try again? y/n");
            string response = Console.ReadLine();
            if (response == "y")
            {
                Console.WriteLine();
                RandomHobby();
            }
        }
    }
}