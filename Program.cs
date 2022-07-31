using MatchmakingSystem;
using System.Text;
using System.Windows.Input;

class Program
{
    public static void Main()
    {
        //取得配對資料
        List<Individual> individuals = DataMaker.AddTestData(10);
        GameMessage message = new GameMessage();
        message.SetPairStrategy();

        //配對
        if (message.PairStrategy == "H")
        {
            MatchSystem matchHabit = new MatchSystem(new HabitStrategy(), individuals);
        }
        else if (message.PairStrategy == "D")
        {
            MatchSystem matchDistance = new MatchSystem(new DistanceStrategy(), individuals);
        }
    }
}


