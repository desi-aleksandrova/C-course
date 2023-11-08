 if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
    while (number > 0)
                {
                    int digit = number % 10;
                    string digitName = GetDigitName(digit);
                    Console.WriteLine(digitName);
                    number /= 10;
                }
    static string GetDigitName(int digit)
{
    switch (digit)
    {
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "unknown";
    }
}
 