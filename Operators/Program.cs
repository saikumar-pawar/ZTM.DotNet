Console.WriteLine("Arithmetic Operators");
Console.WriteLine();
Console.WriteLine("Increment and Decrement");

int a = 4;
int b = a++;
Console.WriteLine($"a: {a}\tb: {b}");

int c = 9;
int d = --c;
Console.WriteLine($"c: {c}\td: {d}");

Console.WriteLine();
Console.WriteLine("addition, substraction, multiplication, division");
int e = 4 + 8;
int f = 5 - 9;
int g = 4 * 11;
int h = 19 / 2;
Console.WriteLine($"e: {e}\tf: {f}\tg: {g}\th: {h}");

int i = 2 + 16 / 2;
int j = (2 + 16) / 2;
Console.WriteLine($"i: {i}\tj: {j}");

Console.WriteLine("Comparision Operators");
int k = 34;
int l = 26;
Console.WriteLine(k > l); //True
Console.WriteLine(k < l); //False
Console.WriteLine(k >= l); //True
Console.WriteLine(k <= l); //False

Console.WriteLine();
Console.WriteLine("Boolean Logical Operators");
bool isRegistered = false;

Console.WriteLine($"isRegistered: {isRegistered}"); //False
Console.WriteLine($"isRegistered: {!isRegistered}"); //True

bool isWednesday = true;
bool isWeekend = false;

Console.WriteLine(isWednesday && isWeekend); //False
Console.WriteLine(isWednesday || isWeekend); //True

Console.WriteLine();
Console.WriteLine("Equality Operators");
string name = "Ramesh";
string country = "Singapore";
int myLuckyNumber = 12;

Console.WriteLine(myLuckyNumber != 25); //True
Console.WriteLine(myLuckyNumber == 12); //True
Console.WriteLine(myLuckyNumber != 12); //False
Console.WriteLine(myLuckyNumber == 25); //False
Console.WriteLine(name == country); //False
