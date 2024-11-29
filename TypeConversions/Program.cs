//Implicit Conversions: No special syntax, no data loss, no precision loss
//Explicit Conversions: Castings, potential data loss, potential precision loss

int age = 25;
float weight = 68.4f;
Console.WriteLine($"age: {age}\tweight: {weight}");

//implicit conversions
long myAge = age;

//explicit conversions
int lessWeight = (int)weight; //precision loss
int notMyAge = (int)myAge; //no precision loss

long bigNumber = 111111111111;
int smallerType = (int)bigNumber;
Console.WriteLine($"smallerType: {smallerType}");
