string inputArray = Console.ReadLine();
string[] numbersStr = inputArray.Split(' ');

if (int.TryParse(Console.ReadLine(), out int N))
{
    if (N >= 1 && N <= numbersStr.Length)
    {
        int[] numbers = new int[numbersStr.Length];

        for (int i = 0; i < numbersStr.Length; i++)
        {
            if (int.TryParse(numbersStr[i], out int number))
            {
                numbers[i] = number;
            }
        }

        double sum = 0;

        for (int i = numbers.Length - N; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = sum / N;

        Console.WriteLine(average.ToString("F2"));
    }
}
