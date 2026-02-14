using System;
using System.IO;

/*
Author: Shania Arvie S. Esguerra
Purpose: W06 - Eternal Quest Project
Description: App that contains gamification features in setting goals. It displays the user's score, achievements,
    and list of goals to keep track of. 
Enhancement: 
    - Added and achievement checker in GoalManager class called AchievementChecker().
        this displays the current achievement that the user has.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // to show emojis

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}