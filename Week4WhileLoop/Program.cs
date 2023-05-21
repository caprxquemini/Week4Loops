
Random rnd = new Random();

int cpuRandom = rnd.Next(1, 4);

bool loopActive = true;

int numberOfTries = 0;

while (numberOfTries < 3)
{
    Console.WriteLine("Guess the CPU number:");

    int userGuess = Convert.ToInt32(Console.ReadLine());

    numberOfTries++;

    if (userGuess == cpuRandom)

        Console.WriteLine("Congratulations! You won!");
        loopActive = false;

}

Console.WriteLine($"Number of tries: {numberOfTries}.")