using MatchmakingSystem;
using System.Text;
using System.Windows.Input;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //取得配對資料
        List<Individual> individuals = DataMaker.AddTestData(30);

        //配對
        MatchSystem match = new MatchSystem(new HabitStrategy(), individuals);
        MatchSystem matchDistance = new MatchSystem(new DistanceStrategy(), individuals);
     
        for (int i = 0; i < match.PairResult.Count; i++)
        {
            Console.WriteLine(match.PairResult[i].ToString());
        }
        Console.ReadKey();
    }
}


