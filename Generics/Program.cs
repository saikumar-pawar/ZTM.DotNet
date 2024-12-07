var cities = new RandomItemGenerator<string>();
cities.Add("mumbai");
cities.Add("chennai");
cities.Add("hyderabad");
cities.Add("kolkata");

for (int i = 0; i < 8; i++)
{
    var randomCity = cities.Get();
    Console.WriteLine(randomCity);
}

var numbers = new RandomItemGenerator<int>();
numbers.Add(28);
numbers.Add(18);
numbers.Add(100);
numbers.Add(54);

for (int i = 0; i < 8; i++)
{
    var randomNumber = numbers.Get();
    Console.WriteLine(randomNumber);
}

public class RandomItemGenerator<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly Random _random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        int index = _random.Next(0, _items.Count);
        return _items[index];
    }
}
