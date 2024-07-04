using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates.Models
{
    public class Party
    {
        public void Cheering(int points)
        {
            System.Console.WriteLine($"Cheering, you have earned {points} points!!!");
        }
    }
}