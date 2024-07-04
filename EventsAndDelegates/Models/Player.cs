using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates.Models
{
    public class Player
    {
        public delegate void UnLockAchievement(int points);
        public event UnLockAchievement? OnLockAchievement;
        public int Points { get; private set; }

        public async Task AddPoints(int points)
        {
            Points += points;
            Console.WriteLine($"Player earned {points} points, total points {Points}");

            await Task.Delay(1000);

            if (Points >= 100)
            {
                OnLockAchievement?.Invoke(Points);
                
            }
        }
    }
}