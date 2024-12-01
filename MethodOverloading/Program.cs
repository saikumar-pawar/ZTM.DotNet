Account account1 = new Account("Tom");
Account account2 = new Account("Sara", 540.5m);
Console.WriteLine($"Account holder: {account1.Owner}\tBalance: {account1.Balance}");
Console.WriteLine($"Account holder: {account2.Owner}\tBalance: {account2.Balance}");

public class Account
{
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }
}
