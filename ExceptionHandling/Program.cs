var content = string.Empty;

try
{
    content = File.ReadAllText("doc.txt");
    Console.WriteLine("The file has been read.");

}
catch (FileNotFoundException exception)
{
    Console.WriteLine($"ERROR: The File '{exception.FileName}' could not be found");
}
finally
{
    Console.WriteLine($"The content length is: {content.Length}");
}

var fileName = "doc.txt";

if (File.Exists(fileName))
{
    var fileContent = File.ReadAllText(fileName);
    Console.WriteLine(fileContent);
}
else
{
    Console.WriteLine("The file does not exist. Do you want to create it?");
}
