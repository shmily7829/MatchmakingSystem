using MatchmakingSystem;

class Program
{
    public static void Main()
    {
        List<Individual> individuals = new List<Individual>();


        var Ming = new Individual()
        {
            Id = 1,

        };

        var Mei = new Individual()
        {

        };

        individuals.Add(Ming);
        individuals.Add(Mei);



        MatchSystem MatchA = new MatchSystem(individuals, new Habit_Based());
        MatchSystem MatchB = new MatchSystem(individuals, new Distance_Based());

        Console.ReadKey();

    }
}


