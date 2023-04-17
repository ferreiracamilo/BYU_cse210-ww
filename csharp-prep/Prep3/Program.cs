using System;

class Program
{
    static void Main(string[] args)
    {
        /* STRETCH 1 */
        int guessesQty = 1;
        
        /* CORE REQ 1 */
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        /* CORE REQ 3 */
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.Write($"Magic number assigned randomly is {magicNumber}\n");

        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        /* CORE REQ 2 */
        while(guessNumber != magicNumber){
            guessesQty++;
            if(guessNumber < magicNumber){
                Console.Write("Higher");
            }else{
                Console.Write("Lower");
            }

            Console.Write("\nWhat is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        }

        Console.Write($"You guessed it on {guessesQty} attemtp/s!");
    }
}