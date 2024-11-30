//if
int myLuckyNumber = 12;

if (myLuckyNumber == 12)
{
    Console.WriteLine("Your're lucky!");
}

Console.WriteLine("Conditionals are cool!");

//if - else
if (myLuckyNumber < 12)
{
    Console.WriteLine("You're lucky number is lower than 12.");
}
else
{
    Console.WriteLine("You're lucky number is 12 or higher.");
}

//if - else if - else
string name = "John";

if (name == "John")
{
    Console.WriteLine("Hi, John!");
}
else if (name == "Sam")
{
    Console.WriteLine("Hi, Sam");
}
else
{
    Console.WriteLine("Hi, nice to meet you!");
}

int version = 5;
int productVersion = version == 5 ? 5 : 4;
Console.WriteLine(productVersion);
