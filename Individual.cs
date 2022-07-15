using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class Individual
    {
        public Individual()
        {

        }

        private Gender _gender;
        private int _age;
        private string _intro;
        private string[] _habits;
        private Coord _coord;

        /// <summary>
        /// 編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// 年齡
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                    throw new ArgumentOutOfRangeException($"年齡須大於18歲，你的年齡{value}歲。");
                _age = value;
            }

        }

        /// <summary>
        /// 介紹
        /// </summary>
        public string Intro
        {
            get; set;
            //get { return _intro; }
            //set
            //{
            //    //if (_intro.Length > 200)
            //    //    throw new ArgumentOutOfRangeException();
            //    //_intro = value;
            //}
        }

        /// <summary>
        /// 興趣
        /// </summary>
        public string[] Habits { get; set; }

        /// <summary>
        /// 座標
        /// </summary>
        public Coord Coord { get; set; } = new Coord(0, 0);

        public Individual RegisterMyIndividual()
        {
            Individual individual = new Individual()
            {
                Id = 1,
                Gender = InputGender(),
                Age = InputAge(),
                Intro = InputIntro(),
                Habits = InputHabits(),
                Coord = InputCoord()
            };

            return individual;
        }

        private Coord InputCoord()
        {
            //需要改成輸入程式轉換座標xy
            Console.WriteLine("請輸入位置");
            string command = Console.ReadLine();
            if (string.IsNullOrEmpty(command))
                throw new ArgumentNullException("輸入資料不可為空!");

            string[] coord = command?.Split(',');

            if (!double.TryParse(coord[0], out double x))
                throw new ArgumentOutOfRangeException("輸入x座標必須為數值");
            if (!double.TryParse(coord[1], out double y))
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
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public class Coord
    {
        public Coord(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

    }
}
