using System.Drawing;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        //Populate the _goals lists
        _score = 0;
    }

    public void Start()
    {
        int userInput = -1;

        while (userInput != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create new Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                ListGoalDetails();
            }
            else if (userInput == 3)
            {
                SaveGoals();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }
            else if (userInput == 6)
            {
                //Goodbye Message:
                Console.WriteLine("Thanks for your time! Quitting....");
            }
            else
            {
                //Error
                Console.WriteLine("Incorrect input. Please type in numbers 1 - 6 to choose a menu option.");
            }

        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        AchievementChecker();
    }

    //ENHANCEMENT FEATURE:
    public void AchievementChecker()
    {
        Console.WriteLine("Achievements: ");
        List<string> achievements = new List<string>();

        //Checks for score milestones and shows rewards:
        if (_score >= 100)
        {
            achievements.Add("  > [ 🥉 Novice Goal Achiever 🤓 ] -- Get a score of 100");
        }
        if (_score >= 500)
        {
            achievements.Add("  > [ 🌳 🏔️ Goal Climber 🏔️ 🌳 ] -- Get a score of 500");
        }
        if (_score >= 1000)
        {
            achievements.Add("  > [ 🥈 Intermediate Goal Achiever ] -- Get a score of 1,000");
        }
        if (_score >= 5000)
        {
            achievements.Add("  > [ 🧗🏼‍♂️ Serious Goal Climber 🏔️ 🚶🏽 ] -- Get a score of 5,000");
        }
        if (_score >= 10000)
        {
            achievements.Add("  > [ 🥇 Expert Goal Achiever 🏆 ] -- Get a score of 10,000");
        }

        foreach (string achievement in achievements)
        {
            Console.WriteLine(achievement);
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            //Simple Goal
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            //Make simple goal
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            //add to the list
            _goals.Add(simpleGoal);

        }
        else if (userInput == "2")
        {
            //Eternal Goal
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            //Make Eternal goal
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            //add to the list
            _goals.Add(eternalGoal);

        }
        else if (userInput == "3")
        {
            //Checklist Goal
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            // Make Checklist goal
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            //add to the list
            _goals.Add(checklistGoal);
        }
        else
        {
            //Incorrect input
            Console.WriteLine("Incorrect input. Try again in the menu by choosing the same option.");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        //record the event:
        _goals[goalNumber - 1].RecordEvent();

        //Get points:
        int points = int.Parse(_goals[goalNumber - 1].GetPoints());
        _score += points; //update total points
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename, false)) //false = overwrite data
        {
            //Add score on the first line
            outputFile.WriteLine(_score);

            //Add the goal entries to the file:
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        //Clear list
        _goals.Clear();

        //Store each line in the file in a string array
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Split into parts
        int count = 0;
        foreach (string line in lines)
        {
            if (count != 0)
            {
                //Split into parts;
                string[] parts = line.Split(":");

                if (parts[0] == "SimpleGoal")
                {
                    //Simple Goal Parts
                    string[] detailParts = parts[1].Split(",");
                    string name = detailParts[0];
                    string description = detailParts[1];
                    string points = detailParts[2];
                    bool isComplete = bool.Parse(detailParts[3]);

                    //Make Goal then add to the list
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsComplete(isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    //Eternal Goal Parts
                    string[] detailParts = parts[1].Split(",");
                    string name = detailParts[0];
                    string description = detailParts[1];
                    string points = detailParts[2];

                    //Make Goal then add to the list
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);

                }
                else if (parts[0] == "ChecklistGoal")
                {
                    //Checklist Goal Parts
                    string[] detailParts = parts[1].Split(",");
                    string name = detailParts[0];
                    string description = detailParts[1];
                    string points = detailParts[2];
                    int bonus = int.Parse(detailParts[3]);
                    int target = int.Parse(detailParts[4]);
                    int amountCompleted = int.Parse(detailParts[5]);

                    //Make Goal then add to the list
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    checklistGoal.SetAmountCompleted(amountCompleted);
                    _goals.Add(checklistGoal);

                }

                count++;//increment count
            }
            else
            {
                //get the score on the first line
                _score = int.Parse(lines[0]);
                count++;
            }

        }
    }
}