// Почти счастливое число
// Петя любит счастливые числа. Всем известно, что счастливыми являются положительные целые числа, в десятичной 
// записи которых содержатся только счастливые цифры 4 и 7. Например, числа 47, 744, 4 являются счастливыми, 
// а 5, 17, 467 — не являются.
// К сожалению, не все числа счастливые. Петя называет число почти счастливым, если количество счастливых цифр в нем
//  — счастливое число. Ему интересно, является ли число n почти счастливым.

int AlmostLuckyNum(int N)
{
    int luckyNum = 0;
    int almostLuckyNum = 0;
    while (N > 0)
    {
        luckyNum = N % 10;
        if (luckyNum == 7 || luckyNum == 4)
        {
            almostLuckyNum++;
        }
        N /= 10;
    }
    return almostLuckyNum;
}
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int lucky = AlmostLuckyNum(n);
if (lucky == 4 || lucky == 7) Console.WriteLine("Yes");
else Console.WriteLine("No");