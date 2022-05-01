// Кодовый замок представляет собой n вращающихся дисков с написанными на них цифрами от 0 до 9.
//  Скрудж МакДак должен повернуть некоторые из дисков так,
//   чтобы последовательность цифр на дисках образовала секретную комбинацию.
//    За одно действие он может прокрутить один из дисков на одну цифру вперед или назад.
//     В частности, за одно действие можно перейти от цифры 0 к цифре 9 и наоборот.
//      Какое минимальное количество действий ему для этого потребуется?

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int code(int n, int[] start, int[] open)
{
    int action = 0;
    for (int i = 0; i < start.Length; i++)
    {
        int count = 0;
        if (start[i] > open[i])
            count = start[i] - open[i];
        else count = open[i] - start[i];
        action += count;
    }
    return action;
}
Console.Write("введите количество дисков на кодовом замке: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] start = new int[n];
int[] open = new int[n];
FillArray(start);
FillArray(open);
PrintArray(start);
PrintArray(open);
int NumberAction = code(n, start, open);
Console.WriteLine($"минимальное колличество действий для открытия замка: {NumberAction}");
