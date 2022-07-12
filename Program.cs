using MatchmakingSystem;

class Program
{
    public static void Main()
    {
        Individual myslef = new Individual();
        myslef.RegisterIndividualData();

        List<Individual> individuals = AddTestPerson(5);

        //MatchSystem HabitMatch = new MatchSystem(new HabitBased(), individuals);
        MatchSystem Distance = new MatchSystem(new DistanceBased(), individuals);

        Console.ReadLine();
    }

    public static List<Individual> AddTestPerson(int count)
    {
        List<Individual> individuals = new List<Individual>();

        for (int i = 1; i <= count; i++)
        {
            var male = new Individual()
            {
                Id = i,
                Age = 20 + i,
                Intro = $"我是測試{i}號。",
                Habits = new string[] { "畫圖", "爬山", "騎腳踏車" },
                Gender = Gender.Male,
                Coord = new Coord(Math.Pow(i, 2), Math.Pow(i, 2))
            };
            individuals.Add(male);
        }
        return individuals;
    }
}


