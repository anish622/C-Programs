using System;
class program
{
    static void Main()
    {
        for (int num = 1; num <= 1000; num++)
        {
            int sum = 0;
            int temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine(num);
            }
        }
    }
}
