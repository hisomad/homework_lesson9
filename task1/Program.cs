Console.Write("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

void FindNumber (int currIndex, int n)
{
    if (currIndex == n) 
        return;
    
    Console.Write("{0,4}", currIndex);
    FindNumber (--currIndex, n);
}

FindNumber(number, 0);
