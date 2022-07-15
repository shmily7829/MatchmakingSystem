using MatchmakingSystem;

class Program
{
    public static void Main()
    {
        try
        {
            //Individual myIndividual = new Individual().RegisterMyIndividual();
            List<Individual> individuals = AddTestPerson(5);
            Individual myIndividual = new Individual()
            {
                Id = 1,
                Age = 25,
                Intro = $"周杰倫最偉大的作品太讚啦!",
                Habits = new string[] { "騎腳踏車" },
                Gender = Gender.Male,
                Coord = new Coord(5, 5)
            };

            Individual mostSameHobit = new Individual()
            {
                Id = individuals.Count + 1,
                Age = 25,
                Intro = $"周杰倫最偉大的作品太讚啦!",
                Habits = new string[] { "聽音樂", "爬山", "騎腳踏車", "寫作", "唱歌" },
                Gender = Gender.Male,
                Coord = new Coord(5, 5)
            };

            individuals.Add(myIndividual);
            individuals.Add(mostSameHobit);

            MatchSystem HabitMatch = new MatchSystem(new HabitBased(), individuals);

            Console.WriteLine(HabitMatch.IsMatch);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }

    public static List<Individual> AddTestPerson(int count)
    {
        List<Individual> individuals = new List<Individual>();

        for (int i = 1; i <= count; i++)
        {
            var male = new Individual()
            {
                Id = i + 1,
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


