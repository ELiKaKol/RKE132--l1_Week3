Console.WriteLine("Enter your assessment");
string userAssessment = Console.ReadLine();


if (userAssessment == "A")
{
    Console.WriteLine("Suurepärane!");
}
else if (userAssessment == "B")
{
    Console.WriteLine("Väga hea!");
}
else if (userAssessment == "C")
{
    Console.WriteLine("Hea!");
}
else if (userAssessment == "D")
{
    Console.WriteLine("Rahuldav");
}
else if (userAssessment == "E")
{
    Console.WriteLine("Kasin");
}
else if (userAssessment == "F")
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine($"Vale väärtus");
}