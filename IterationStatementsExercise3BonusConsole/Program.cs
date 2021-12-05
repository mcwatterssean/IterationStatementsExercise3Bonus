
/*    PrintThousand();
    PrintThrees();
    Console.WriteLine(IsEqual(5, 5));
    EvenOrOdd(0);
    PosOrNeg(-55432);
static void PrintThousand()
{
    for(int i = 1000; i >= -1000; i--)
    {
        Console.WriteLine(i);
    }
}


static void PrintThrees()
{
    for(int t = 3; t <=999; t +=3)
    {
        Console.WriteLine(t);
    }

}

static bool IsEqual(int a, int b)
{
    var check = a == b ? true : false;

    return check;
}

static void EvenOrOdd(int c)
{
    if (c % 2 == 0)
    {
        Console.WriteLine($"{c} is even");
    }
    else if (c % 2 != 0)
    {
        Console.WriteLine($"{c} is odd");
    }
}

static void PosOrNeg(int d)
{
    if (d >= 0)
    {
        Console.WriteLine($"{d} is Positive");
    }
    else if (d < 0)
    {
        Console.WriteLine($"{d} is Negative");
    }
}



Console.Write("What is your age?");
int age;
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Could not compute, try again");
}

AgeChecker(age);

static void AgeChecker(int userAge)
{
    if (userAge >= 18)
    {
        Console.WriteLine("You are eligible to vote");
    }
    else
    {
        Console.WriteLine("You are not old enough to vote");
    }
}


Console.WriteLine("Choose a number between -10 and 10");
int userNumber = int.Parse(Console.ReadLine());
RangeChecker(userNumber);

static void RangeChecker(int userNumber)
{
    if (userNumber <= 10 && userNumber >= -10)
    {
        Console.WriteLine("Your number is in range");
    }    
    else
        {
        Console.WriteLine("Your number is not in range");
    }

}
*/

Console.WriteLine("Choose a number to multiply");
int userAnswer = int.Parse(Console.ReadLine());
Multitable(userAnswer);

static void Multitable(int userAnswer)
{
    int product = 0;

    for (int i = 1; i <=12; i++)
    {
        product = userAnswer * i;
        Console.WriteLine($"{userAnswer} X {i} = {product}");
    }
}



