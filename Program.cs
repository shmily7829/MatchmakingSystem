using MatchmakingSystem;
using System.Text;

class Program
{
    public static void Main()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            //取得配對資料
            //Individual myIndividual = new Individual().RegisterMyIndividual();
            List<Individual> individuals = DataMaker.AddTestData(30);

            //執行配對
            MatchSystem HabitMatch = new MatchSystem(new HabitStrategy(), individuals);
            for (int i = 0; i < HabitMatch.PairResult.Count; i++)
            {
                Console.WriteLine(HabitMatch.PairResult[i].ToString()); 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}


