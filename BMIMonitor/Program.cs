using BMIMonitor.ReferenceTypes;

var person = new Person
{
    FirstName = "Lars",
    LastName = "Larsen",
    Weight = 80,
    Height = 1.80
};

person.CalculateBMI();
Console.WriteLine($"{person.FirstName} {person.LastName} har en BMI på: {person.BMI}");
