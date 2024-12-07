Person person1 = new Person("James", 32, 4);
Person person2 = new Person(name: "Rahul", age: 28, luckyNumber: 8);
Person person3 = new Person(age: 41, name: "Sam", luckyNumber: 9);
Person person4 = new Person("Ram", age: 26, luckyNumber: 12);

public class Person
{
    public Person(string name, int age, int luckyNumber)
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
}
