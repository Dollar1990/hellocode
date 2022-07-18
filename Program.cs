int getRandomNumber(int minBorder, int maxBorder)
{
   return new Random().Next(minBorder, maxBorder + 1);
}
int getMaxDigit(int number)
{
        int maxDigit = 0;
        int digitOne = number / 10;
        int digitTwo = number % 10;
        maxDigit = digitOne;
        if(maxDigit < digitTwo)
        {
            maxDigit = digitTwo;
        }
    return maxDigit;
}
int randomNumber = getRandomNumber(10,99);
int maxDigit = getMaxDigit (randomNumber);
Console.WriteLine($" Наибольшая цифра числа {randomNumber} это {maxDigit}");