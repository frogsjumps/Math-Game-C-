using System.Security.Authentication.ExtendedProtection;

int userAnswer;
int userAnswer2;
int userAnswer3;

Console.WriteLine("Welcome to the math game! Solve these problems: ");
Console.WriteLine("");

Console.Write("15 + 2 * 2 = ");
userAnswer = Convert.ToInt32( Console.ReadLine() );

if(userAnswer == 19){
    Console.WriteLine("Correct!");
} else {
    Console.WriteLine("Wrong!");
}

Console.Write("10 * 2 / 4 = ");
userAnswer2 = Convert.ToInt32(Console.ReadLine() );

if (userAnswer2 == 5){
    Console.WriteLine("Correct!");
} else {
    Console.WriteLine("Wrong!");
}

Console.Write("(4 + 3 + 2 + 1) / 2 = ");
userAnswer3 = Convert.ToInt32(Console.ReadLine());

if (userAnswer3 == 5){
    Console.WriteLine("Correct!");
} else {
    Console.WriteLine("Wrong!");
}

Console.ReadKey();



