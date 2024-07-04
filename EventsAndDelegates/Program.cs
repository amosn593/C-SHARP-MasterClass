// See https://aka.ms/new-console-template for more information
using EventsAndDelegates.Models;


var player = new Player();
var party = new Party();

player.OnLockAchievement += OnLockAchievement;
player.OnLockAchievement += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(40);

player.OnLockAchievement -= OnLockAchievement;
player.OnLockAchievement -= party.Cheering;


static void OnLockAchievement(int points)
{
    Console.WriteLine($"Congratulations, you have earned {points} points!!!");
}