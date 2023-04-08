// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void AkkermanFunction(int m, int n)
{
    System.Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

AkkermanFunction(m, n);

