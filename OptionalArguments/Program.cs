Person Person1 = new Person("Justin", 36);
Person person2 = new Person("Rakesh", 42, 4);
Person person3 = new Person("Ricky", luckyNumber: 2, age: 48);
Person person4 = new Person("Ramesh", 60, favoriteColor: "black");

Person1.PrintSummary();
person2.PrintSummary();
person3.PrintSummary();
person4.PrintSummary();

public class Person
{
    public Person(string name, int age, int luckyNumber = 8, string favoriteColor = "orange")
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
        FavoriteColor = favoriteColor;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavoriteColor { get; set; }

    public void PrintSummary()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nLuckyNumber: {LuckyNumber}\nFavoriteColor: {FavoriteColor}");
    }
}
