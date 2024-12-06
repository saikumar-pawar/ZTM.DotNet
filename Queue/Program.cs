var messages = new Queue<string>();

messages.Enqueue("Hello");
messages.Enqueue("Good morning");
messages.Enqueue("Good evening");

while (messages.Count > 0)
{
    var message = messages.Dequeue();
    Console.WriteLine(message);
}
