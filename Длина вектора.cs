double o, n;
int i;
int [] dotOne ={0,0,0};
int [] dotTwo ={0,0,0};
//int j = 3;

int CorrectInput()
{
    bool check;
    string? UserNumber;
    int number = 0;
    check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}
Console.WriteLine($"Ввод кординат точек вектра.");

for (i = 0; i < 3; i++)
{
    Console.Write($"Введите {i+1} кординату точки:");
    dotOne[i] = CorrectInput();
}
for (i = 0; i < 3; i++)
{
    Console.Write($"Введите {i+1} кординату второй точки:");
    dotTwo[i] = CorrectInput();
}

n = 0;
for (i = 0; i < 3; i++)
{
    n += Math.Pow(dotTwo[i]-dotOne[i], 2);
}
o = Math.Sqrt(n);
Console.Write($"Длина вектора = {o}");