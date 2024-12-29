var buildings = new List<Building>{
    new Building("Magadha", 1500, 200.6m),
    new Building("Spring", 2600, 435.77m),
    new Building("Attari", 1400, 148.28m),
    new Building("Empire State", 12550, 840.32m),
};

var totalEstimatedTax = buildings.Sum(b => b.SizeInSqrFt * b.TaxPerSqrFt);
Console.WriteLine($"Total Estimated Tax: {totalEstimatedTax}");

public record Building(string Name, ushort SizeInSqrFt, decimal TaxPerSqrFt);
