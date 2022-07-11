using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class Individual
    {
        public int Id { get; set; }
        public enum Gender
        {
            Male,
            Female,
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age < 18)
                    throw new ArgumentOutOfRangeException();
                _age = value;
            }

        }

        private string _intro;

        public string Intro
        {
            get { return _intro; }
            set
            {
                if (_intro.Length > 200)
                    throw new ArgumentOutOfRangeException();
                _intro = value;
            }
        }

        public string[] Habits { get; set; }

        private string _habit;

        public string Habit
        {
            get { return _habit; }
            set
            {
                if (_habit.Length > 10)
                    throw new ArgumentOutOfRangeException();
                _habit = value;
            }
        }

        public enum Coord
        {
            x,
            y
        }

    }
}
