using System;

class Program
{
    /*
    
    DATA SAMPLE

    *** SIMPLE GOAL ***
    Name: Give a talk
    Description: Speak in Sacrament meeting when asked
    Base points: 100

    *** ETERNAL GOAL ***
    Name: Study the scriptures
    Description: Study for at least 10 minutes
    Base points: 50

    *** CHECKLIST GOAL ***
    Name: Attend the temple
    Description: Attend and perform any ordinance
    Base points: 50
    Bonus Quantity Goal: 3
    Bonus Points: 500

    *** REDUCTION GOAL ***
    Name: Institute Online Gathering Disruption
    Description: Watching TV meanwhile institute online gathering
    Base points: 30

     */

    static void Main(string[] args){
        int _option = 0;
        int _counter;
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
                        break;
                    case 4:
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
}