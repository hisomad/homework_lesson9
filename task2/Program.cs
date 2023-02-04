Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void SumOfNumbers (int m, int n, int result)
{
    if (m > n)
    {
        System.Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N -> {result}");
            return;
    }
    
    result = result + (m++);
    SumOfNumbers(m, n, result);
}

SumOfNumbers(m, n, 0);
