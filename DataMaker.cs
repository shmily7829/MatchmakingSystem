using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class DataMaker
    {
        static readonly Random random = new Random();
        public static Individual GenerateIndividual()
        {
            Individual individual = new Individual()
            {
                Gender = RandomGender(),
                Age = RandomAge(18, 40),
                Habits = RandomHabits(1, 5),
                Coord = RandomCoord(0, 300)
            };
            return individual;
        }

        public static List<Individual> AddTestData(int count)
        {
            List<Individual> testDataList = new List<Individual>();

            for (int i = 0; i < count; i++)
            {
                testDataList.Add(GenerateIndividual());
            }
            SetIndividualId(testDataList);

            //PrintData(testDataList);

            return testDataList;
        }

        private static void SetIndividualId(List<Individual> individuals)
        {
            for (int i = 0; i < individuals.Count; i++)
            {
                individuals[i].Id = i + 1;
            }
        }

        private static void PrintData(List<Individual> testData)
        {
            Console.WriteLine("==========TestDataBegin============");
            foreach (var individual in testData)
            {
                Console.WriteLine(individual.ToString());
            }
            Console.WriteLine("==========TestDataEnd============");
        }

        private static Gender RandomGender()
        {
            return (Gender)Enum.Parse(typeof(Gender), random.Next(1, 3).ToString());
        }

        private static int RandomAge(int min, int max)
        {
            return random.Next(min, max);
        }

        private static string[] RandomHabits(int min, int max)
        {
            List<string> habitList = new List<string>()
            {
                "閱讀",
                "書法",
                "繪畫",
                "攝影",
                "寫作",
                "登山",
                "游泳",
                "羽球",
                "網球",
                "籃球",
                "棒球",
                "足球",
                "衝浪",
                "溜冰",
                "滑雪",
            };
            StringBuilder sbHabits = new StringBuilder();

            int randomcount = random.Next(min, max);
            List<string> list = habitList.OrderBy(x => random.Next(min, max)).ToList();

            for (int i = 0; i < randomcount; i++)
            {
                sbHabits.Append($"{list[i]},");
            }

            return sbHabits.ToString().TrimEnd(',').Split('\u002C');
        }

        private static Coord RandomCoord(int min, int max)
        {
            return new Coord(random.Next(min, max), random.Next(min, max));
        }

        #region old
        private Coord InputCoord()
        {
            //需要改成輸入程式轉換座標xy
            Console.WriteLine("請輸入位置");
            string command = Console.ReadLine();
            if (string.IsNullOrEmpty(command))
                throw new ArgumentNullException("輸入資料不可為空!");

            string[] coord = command?.Split(',');

            if (!float.TryParse(coord[0], out float x))
                throw new ArgumentOutOfRangeException("輸入x座標必須為數值");
            if (!float.TryParse(coord[1], out float y))
                throw new ArgumentOutOfRangeException("輸入y座標必須為數值");

            return new Coord(x, y);
        }

        private string[] InputHabits()
        {
            Console.WriteLine("你有什麼興趣呢？(可填寫多個興趣，每個興趣請用逗號隔開)");

            string command = Console.ReadLine() ?? string.Empty;

            string[] habits = command?.Split(',');

            return habits;
        }

        private string InputIntro()
        {
            Console.WriteLine("稍微介紹一下自己吧！(字數限制在200字內)");

            string intro = Console.ReadLine() ?? string.Empty;
            if (intro != null && intro.Length > 200)
            {
                throw new ArgumentOutOfRangeException("輸入的介紹不可超過200字");
            }
            return intro;
        }
        private int InputAge()
        {
            Console.WriteLine("請輸入年齡");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                throw new ArgumentException("年齡請輸入純數字");
            }
            else
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException("年齡須大於18歲");
                }
                if (age > 130)
                {
                    throw new ArgumentOutOfRangeException("輸入的年齡須在正常範圍內");
                }
            }
            return age;
        }

        private Gender InputGender()
        {
            Console.WriteLine("請輸入性別代號：男=1、女=2、其他=3");
            if (!int.TryParse(Console.ReadLine(), out int gender))
            {
                throw new ArgumentException("性別代號輸入錯誤");
            }
            else
            {
                if (gender < 1 || gender > 3)
                {
                    throw new ArgumentOutOfRangeException("輸入的代號不在範圍內");
                }
            }
            return (Gender)Enum.Parse(typeof(Gender), gender.ToString());
        }
        #endregion
    }
}
