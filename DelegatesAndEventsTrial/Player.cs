using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsTrial
{
    internal class Player
    {
        public int Points { get; set; }

        public delegate void AchievementUnlockedhandler(int point);

        public event AchievementUnlockedhandler? AchievementUnlocked;

        public async Task AddPoints(int point)
        {
            Points += point;
            Console.WriteLine($"Player earned {point} points. Total points: {Points}");
            await Task.Delay(2000);

            if (Points >= 100)
            {
                AchievementUnlocked?.Invoke(Points);
                
            }
        }
    }
}
