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
        private int _age;

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
            //get;set;
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
    }

    public enum Gender
    {
        Male,
        Female,
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
