using System;
using System.IO;

class Program
{
    static void Main(string[] args){
        int _option = 0;
        int _counter;
        string fileName;
        List<Goal> _goalList = new List<Goal>();

        do{
            _option = PrintMenu();
            if(_option != 6){
                switch(_option){
                    case 1:
                        int _goalType;
                        Console.Clear();
                        _goalType = PrintMenuGoalCreation();

                        switch(_goalType){
                            case 1:
                                SimpleGoal simpleGoal = new SimpleGoal();
                                simpleGoal.AskInformation();
                                _goalList.Add(simpleGoal);
                                break;
                            case 2:
                                EternalGoal eternalGoal = new EternalGoal();
                                eternalGoal.AskInformation();
                                _goalList.Add(eternalGoal);
                                break;
                            case 3:
                                ChecklistGoal checklistGoal = new ChecklistGoal();
                                checklistGoal.AskInformation();
                                _goalList.Add(checklistGoal);
                                break;
                            case 4:
                                ReductionGoal reductionGoal = new ReductionGoal();
                                reductionGoal.AskInformation();
                                _goalList.Add(reductionGoal);
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        _counter = 1;
                        foreach(Goal g in _goalList){    
                            Console.WriteLine($"{_counter}. {g.ToText(true)}");
                            _counter++;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("What is the filename for the goal file" );
                        fileName = Console.ReadLine();
                        using (StreamWriter outputFile = new StreamWriter(fileName)){
                            foreach(Goal g in _goalList){
                                outputFile.WriteLine(g.ToText(false)); 
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("What is the filename for the goal file" );
                        fileName = Console.ReadLine();
                        _goalList = LoadGoals(fileName);
                        break;
                    case 5:
                        int _totalPoints = 0;
                        int _goalOption = 0;
                        _counter = 1;

                        Console.Clear();
                        
                        foreach(Goal g in _goalList){    
                            Console.WriteLine($"{_counter}. {g.GetName()}");
                            _counter++;
                        }

                        Console.Write("\nWhich goal did you accomplished or missbehavior you committed? ");
                        _goalOption = int.Parse(Console.ReadLine());

                        Goal _goalToLoadEvent = _goalList[_goalOption-1];
                        _goalToLoadEvent.RecordEvent();
                        
                        foreach(Goal g in _goalList){
                            _totalPoints += g.CalculatePoints();
                        }
                        Console.WriteLine($"\nYou have accumulated {_totalPoints} points so far.");
                        break;
                }
            }
        }while(_option != 6);
    }

    private static int PrintMenu(){
        int option;
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());
        return option;
    }

    private static int PrintMenuGoalCreation(){
        int option;
        Console.WriteLine("\nThe types of Goals are");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("    4. Reduction Goal");
        Console.Write("Which type of goal would you like to create? ");
        option = int.Parse(Console.ReadLine());
        return option;
    }

    private static List<Goal> LoadGoals(string fileName){
        List<Goal> _goalList = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines){
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalRewardPoints = int.Parse(parts[3]);
            int goalCompletionCount = int.Parse(parts[4]);

            switch(goalType){
                case "ChecklistGoal":
                    int goalBonusQualificationGoalCount = int.Parse(parts[5]);
                    int goalBonusQualificationGoalRewardPoints = int.Parse(parts[6]);
                    ChecklistGoal checkGoal = new ChecklistGoal(goalType, goalDescription, goalRewardPoints, goalCompletionCount, goalBonusQualificationGoalCount, goalBonusQualificationGoalRewardPoints);
                    _goalList.Add(checkGoal);
                    break;
                case "ReductionGoal":
                    ReductionGoal reductionGoal = new ReductionGoal(goalType, goalDescription, goalRewardPoints, goalCompletionCount);
                    _goalList.Add(reductionGoal);
                    break;
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(goalType, goalDescription, goalRewardPoints, goalCompletionCount);
                    _goalList.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(goalType, goalDescription, goalRewardPoints, goalCompletionCount);
                    _goalList.Add(eternalGoal);
                    break;
            }
        }
        return _goalList;
    }

}