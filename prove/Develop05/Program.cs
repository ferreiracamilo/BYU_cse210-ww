using System;

class Program
{
    static void Main(string[] args){
        int option = 0;
        int counter = 0;
        List<Goal> goalList = new List<Goal>();

        do{
            option = PrintMenu();
            if(option != 6){
                switch(option){
                    case 1:
                        int goalType;
                        Console.Clear();
                        goalType = PrintMenuGoalCreation();

                        switch(goalType){
                            case 1:
                                SimpleGoal simpleGoal = new SimpleGoal();
                                simpleGoal.AskInformation();
                                goalList.Add(simpleGoal);
                                break;
                            case 2:
                                EternalGoal eternalGoal = new EternalGoal();
                                eternalGoal.AskInformation();
                                goalList.Add(eternalGoal);
                                break;
                            case 3:
                                ChecklistGoal checklistGoal = new ChecklistGoal();
                                checklistGoal.AskInformation();
                                goalList.Add(checklistGoal);
                                break;
                            case 4:
                                ReductionGoal reductionGoal = new ReductionGoal();
                                reductionGoal.AskInformation();
                                goalList.Add(reductionGoal);
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        counter = 1;
                        foreach(Goal g in goalList){    
                            Console.WriteLine($"{counter}. {g.ToText(true)}");
                            counter++;
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.Clear();
                        counter = 1;
                        foreach(Goal g in goalList){    
                            Console.WriteLine($"{counter}. {g.ToText(true)}");
                            counter++;
                        }
                        break;
                }
            }
        }while(option != 6);
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