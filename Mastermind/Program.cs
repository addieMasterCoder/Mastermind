using System;

class Program
{
    static void Main()
    {
        //Make a random object to call random on
        Random random = new Random();

        //make the secret code
        int codeOne = random.Next(1, 7);
        int codeTwo = random.Next(1, 7);
        int codeThree = random.Next(1, 7);
        int codeFour = random.Next(1, 7);
        
        //v for testing purposes
        //int codeOne = 1;
        //int codeTwo = 2;
        //int codeThree = 3;
        //int codeFour = 4;

        //Putting the code into an array in case I need it
        int[] codeArray = new int[] { codeOne, codeTwo, codeThree, codeFour};

        //Make blank variables to hold user answers
        // v these = 0 so VS code would stop being mad at me and giving me the red squiggly line when I tried to use them later
            int answerOne = 0;
            int answerTwo = 0;
            int answerThree = 0;
            int answerFour = 0;

        //Make a blank string to return the user input
            string results = "";

        //Make a variable break the loop
        bool isCorrectAnswer = false;


        Console.WriteLine("Hello!  Welcome to Mastermind.");
        Console.WriteLine("I am going to think of four integers between the values of 1 and 6.");
        Console.WriteLine("To play, guess four integers between 1 and 6.");
        Console.WriteLine("If you guess a correct integer in the correct position, I will let you know with a plus sign.");
        Console.WriteLine("If you guess a correct integer in an incorrect position, I will let you know with a minus sign.");
        Console.WriteLine("You will have ten guesses to guess my code.");
        
        // v for testing purposes
        //Console.WriteLine(codeOne);
        //Console.WriteLine(codeTwo);
        //Console.WriteLine(codeThree);
        //Console.WriteLine(codeFour);

        //Start the for loop here
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"Guess #{i}:");
            // v infinite loop until user gives an integer
            while (true)
            {
                try
                {
                    Console.WriteLine("When you are ready, please enter your first number between 1 and 6:");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    if (number >= 1 && number <= 6)
                    {
                        answerOne = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 6.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter one of the following integers: 1, 2, 3, 4, 5, or 6.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("When you are ready, please enter your second number between 1 and 6:");
                    string input = Console.ReadLine();
                    int number = int.Parse(input); 
                    if (number >= 1 && number <= 6)
                    {
                        answerTwo = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 6.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter one of the following integers: 1, 2, 3, 4, 5, or 6.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("When you are ready, please enter your third number between 1 and 6:");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    if (number >= 1 && number <= 6)
                    {
                        answerThree = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 6.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter one of the following integers: 1, 2, 3, 4, 5, or 6.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("When you are ready, please enter your fourth number between 1 and 6:");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);

                    if (number >= 1 && number <= 6)
                    {
                        answerFour = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 6.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter one of the following integers: 1, 2, 3, 4, 5, or 6.");
                }
            }

            // Now I have the Answer and the Guess, I should compare them like FooBar

            if (answerOne == codeOne)
            {
                results += "+";
            }
            if (answerTwo == codeTwo)
            {
                results += "+";
            }
            if (answerThree == codeThree)
            {
                results += "+";
            }
            if (answerFour == codeFour)
            {
                results += "+";
            }

            if (codeArray.Contains(answerOne) && answerOne != codeOne)
            {
                results += "-";
            }
            if (codeArray.Contains(answerTwo) && answerTwo != codeTwo)
            {
                results += "-";
            }
            if (codeArray.Contains(answerThree) && answerThree != codeThree)
            {
                results += "-";
            }
            if (codeArray.Contains(answerFour) && answerFour != codeFour)
            {
                results += "-";
            }
            Console.WriteLine(results);

            // v because in a case like 2234 the results will be ++++-- but the player still won the game
            if (results.Length >= 4 && results.Substring(0, 4) == "++++")
            {
                isCorrectAnswer = true;
            }
            if (results == "++++")
            {
                isCorrectAnswer = true;
            }
            if (isCorrectAnswer)
            {
                Console.WriteLine("Congrats, You Have Won the Game!");
                break;
            }
            // Clear results for next iteration
            results = "";
            // Dunk on them if i is 10
            if (i == 10)
            {
                Console.WriteLine("Sorry, you have lost the game");
                Console.WriteLine("The code was:");
                Console.WriteLine(codeOne);
                Console.WriteLine(codeTwo);
                Console.WriteLine(codeThree);
                Console.WriteLine(codeFour);
            }
        }
    }
}
