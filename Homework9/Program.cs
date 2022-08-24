// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64()
{
    Console.WriteLine("Введите натуральное число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M <= 0 || N <= 0)
        Console.WriteLine("Введены не натуральные числа!");
    else
    {
        if (M > N)
        {
            int temp = M;
            M = N;
            N = temp;
        }

        NumberMN(N, M);
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
void Zadacha66()
{
    Console.WriteLine("Введите натуральное число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M <= 0 || N <= 0)
        Console.WriteLine("Введены не натуральные числа!");
    else
    {
        if (M > N)
        {
            int temp = M;
            M = N;
            N = temp;
        }

        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SummaMN(M, N)}");
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
void Zadacha68()
{
    Console.WriteLine("Введите неотрицательное целое число m");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное целое число n");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M < 0 || N < 0)
        Console.WriteLine("Введите неотрицательные целые числа!");
    else
    {
        Console.WriteLine($"Значение функции Аккермана равна {FunctionAkkermana(M, N)}");
    }
}


void NumberMN(int number, int counter = 1)
{
    if (counter > number) return;
    if (counter % 3 == 0)
        Console.Write(counter + "  ");
    counter++;
    NumberMN(number, counter);
}

int SummaMN(int number1, int number2, int result = 0)
{
    if (number2 < number1)
    {
        return result;
    }

    result += number2;
    number2--;
    return SummaMN(number1, number2, result);
}

int FunctionAkkermana(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0 && numberM > 0) return FunctionAkkermana(numberM - 1, 1);
    return FunctionAkkermana(numberM - 1, FunctionAkkermana(numberM, numberN -1));
}


Zadacha64();
Zadacha66();
Zadacha68();
