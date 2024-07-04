// See https://aka.ms/new-console-template for more information
using EventsAndDelegates.Models;

//Delegates and Events

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

//Publisher and subscriber Mechanism
var author = new Author("Author1", "Description 1");
var user_1 = new User("User_1");
var user_2 = new User("User_2");

//author.AddSubcriber(user_1);
author.OnPublish += (sender, args) => user_1.Notify(args.Message);

user_2.Subscribe(author);

var article = new Article("DDD", "From eyes of a senior dev", author.Id);

author.Publish(article);

Console.ReadLine();