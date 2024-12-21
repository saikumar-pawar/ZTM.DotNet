
namespace MVCFundamentals.Data;

public class PersonService : IPersonService
{
    public IEnumerable<Person> GetAll()
    {
        return [
            new Person(1, "rohit", "sharma", new DateTime(1988, 4, 25)),
            new Person(2, "rakesh", "verma", new DateTime(1992, 8, 15))
            ];
    }
}
