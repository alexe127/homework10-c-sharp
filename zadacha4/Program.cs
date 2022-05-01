// Солдат хочет купить w бананов в магазине.
//  Ему надо заплатить k долларов за первый банан,
//   2k долларов — за второй и так далее (иными словами, за i-й банан надо заплатить i·k долларов).
// У него есть n долларов. Сколько долларов ему придется одолжить у однополчанина, чтобы купить w бананов?

int borrowedMoney(int k, int n, int w)
{
    int sum = 0;
    for (int i = 1; i<=w;i++)
    {
        sum += i*k;
    }
    if(sum>n) 
    return sum-n;
    else 
    return 0;
}

Console.Write("введите цену 1 банана : ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.Write("введите, изначальное количество долларов у солдата : ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("введите, количество бананов, которые солдат хочет купить : ");
int w = int.Parse(Console.ReadLine() ?? "0");
int NeedBorrowedMoney= borrowedMoney(k, n, w);
Console.WriteLine($"Солдат должен одолжить {NeedBorrowedMoney} $");