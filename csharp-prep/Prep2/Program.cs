using System;

class Program
{
    static void Main(string[] args)
    {
        string pass_statement = "";
        string letter_statement = "";

        /* CORE REQ - 1 & 3 */
        Console.Write("Input your grade percentage: ");
        int grade_number = int.Parse(Console.ReadLine());

        if(grade_number >= 90){
            letter_statement = "A";
        }else if(grade_number >= 80){
            letter_statement = "B";
        }else if(grade_number >= 70){
            letter_statement = "C";
        }else if(grade_number >= 60){
            letter_statement = "D";
        }else{
            letter_statement = "F";
        }

        /* CORE REQ - 2 */
        if(grade_number >= 70){
            pass_statement = "Congratulations, you did great and passed your course";
        }else{
            pass_statement = "This is not your lucky day, unfortunately you have not passed. Anyways is for sure you'll do great next time.";
        }
        Console.Write(pass_statement);

        /* STRETCH CHALLENGE 1,2 & 3 */
        if(grade_number < 97 && grade_number >= 60){
            //Assure A+ and F- or F+ won't be considered

            if(grade_number%10 >= 7){
                letter_statement += "+";
            }

            if(grade_number%10 < 3){
                letter_statement += "-";
            }
        }

        Console.Write($"\nYour grade is {letter_statement}");
    }
}