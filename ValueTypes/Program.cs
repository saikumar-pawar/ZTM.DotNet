
bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"char: {c1}");

int a = 2;
int b = 5;
int c = 12;
Console.WriteLine($"a: {a}\tb: {b}\tc: {c}");

//arithmentic operations
int multiply = a * b;
int divide = c / b;
int add = a + b;
int substract = a - b;
Console.WriteLine($"multiply: {multiply}\tdivide: {divide}\tadd: {add}\tsubstract: {substract}");

long i = 58;
Console.WriteLine($"long: {i}");

//floating point numbers
float f = 2.458f;
double d = 5.34d;
decimal dec = 3.8642m;
Console.WriteLine($"float: {f}\tdouble: {d}\tdecimal: {dec}");

Console.WriteLine($"float calculation: {1.1111111f / 0.8324234f}");
Console.WriteLine($"double calculation: {1.1111111d / 0.8324234d}");
Console.WriteLine($"decimal calculation: {1.1111111m / 0.8324234m}");

//copying values
int a1 = 4;
int a2 = a1;
a1 = 6;
Console.WriteLine($"a1: {a1}\ta2: {a2}");

//nullable value types
int? v1 = null;
bool? b1 = null;
Console.WriteLine($"int?: {v1}\tbool?: {b1}");
