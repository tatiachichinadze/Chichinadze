
string[] students = new string[3];

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Enter students name {i + 1};");
    students[i] = Console.ReadLine();
}
Console.WriteLine("List of students");
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i + 1} {students[i]}");
}