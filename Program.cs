Console.WriteLine("Привет! Какое имя ты бы хотел поместить внутрь прямоугольника?");
string name = Console.ReadLine();

Console.WriteLine("В какие символы его поместить?");
string symbol = Console.ReadLine();

for (int i = 0; i < name.Length; i++)
{
    Console.Write(symbol);
}

string middleRow = symbol + name + symbol;

Console.WriteLine("\n" + middleRow);

for (int i = 0; i < name.Length; i++)
{
    Console.Write(symbol);
}