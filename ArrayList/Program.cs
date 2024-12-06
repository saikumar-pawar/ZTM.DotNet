using System.Collections;

ArrayList arrayList = new ArrayList();

int day = 12;
arrayList.Add(day);

Person person1 = new Person("Ram");
arrayList.Add(person1);

foreach (var item in arrayList)
{
    if (item is Person)
    {
        var person = item as Person;
        if (person != null)
        {
            Console.WriteLine(person.Name);
        }
    }
    else
    {
        Console.WriteLine(item);
    }
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
