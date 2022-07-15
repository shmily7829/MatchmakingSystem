using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class HabitBased : IMatchmakingStrategy
    {
        public HabitBased()
        {

        }

        //興趣先決(Habit-Based)：配對與自己興趣擁有最大交集量的對象（興趣交集量相同則選擇編號較小的那位）。
        public bool MakeMatch(List<Individual> individuals)
        {
            //Console.WriteLine($"測試興趣配對，共{individuals.Count}人");

            Individual myData = individuals.Where(c=> c.Id == 1).First();
            individuals.Remove(myData);

            List<string> sameHabits = new List<string>();
            int maxMappingCount = 0;
            int lastMappingCount = 0;
            try
            {
                foreach (var item in individuals)
                {
                    sameHabits.Clear();
                    maxMappingCount = 0;

                    foreach (var myHabit in myData.Habits)
                    {
                        foreach (var habit in item.Habits)
                        {
                            if (myHabit.Equals(habit))
                            {
                                sameHabits.Add(habit);
                                maxMappingCount++;
                            }
                        }
                    }
                }
                if (maxMappingCount > lastMappingCount)
                {
                    lastMappingCount = maxMappingCount;
                }

                Console.WriteLine(maxMappingCount);
                foreach (var item in sameHabits)
                {
                    Console.WriteLine(item);
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return maxMappingCount > 0 ? true : false;
        }
    }
}
