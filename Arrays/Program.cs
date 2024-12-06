int[] array1 = new int[5];

array1[0] = 5;
array1[1] = 10;
array1[2] = 15;
array1[3] = 20;
array1[4] = 25;

Console.WriteLine(array1);
Console.WriteLine(array1[1]);

//Array initializer
int[] array2 = new int[] { 2, 4, 6, 8 };
Console.WriteLine(array2);
Console.WriteLine(array2[2]);

//Alternative Syntax
int[] array3 = { 3, 6, 9, 12 };
Console.WriteLine(array3);
Console.WriteLine(array3[3]);

//Uninitialized elements
int[] array4 = new int[5];
Console.WriteLine(array4);
Console.WriteLine(array4[2]);

Person[] persons = new Person[2];
persons[0] = new Person("Ricky");
persons[1] = new Person("Pointing");
Console.WriteLine(persons);
Console.WriteLine(persons[0].Name);

foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
