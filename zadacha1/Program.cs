// Юра и заселение
// Недавно Юра поступил в БГУКП (Берляндский Государственный Университет Крутых Программистов).
//  У Юры есть друг Леша, который поступил вместе с ним, и теперь они заселяются в общежитие.

// Юра и Леша хотят жить в одной комнате. Всего в общежитии есть n комнат.
//  В данный момент в комнате с номером i живут pi человек,
//  когда всего в этой комнате может жить qi человек (pi ≤ qi).
//   Посчитайте, сколько комнат общежития смогут вместить Юру и Лешу вместе?

int[,] GetOccupancyRoom(int n)
{
    int[,] OccupancyRoom = new int[n, 2];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"введите, сколько человек живет в комнате {i+1} : ");
        OccupancyRoom[i, 0] = int.Parse(Console.ReadLine() ?? "0");
        Console.Write($"введите, вместимость комнаты {i+1} : ");
        OccupancyRoom[i, 1] = int.Parse(Console.ReadLine()?? "0");
    }
    return OccupancyRoom;
}
int NumberRooms(int[,] filledRoom)
{
    int Numbers = 0;
    for (int i = 0; i < filledRoom.GetLength(0); i++)
    {
        if (filledRoom[i, 1] - filledRoom[i, 0] >= 2) Numbers++;
    }
    return Numbers;
}

Console.Write("введите число комнат: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] OccupancyRoom = GetOccupancyRoom(n);
Console.WriteLine(NumberRooms(OccupancyRoom));