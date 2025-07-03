internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(HighAndLowLinq("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }

    public static string HighAndLow(string numbers)
    {
        // Code here or
        var max = int.MinValue;
        var min = int.MaxValue;

        var numberSplit = numbers.Split(' ');

        for (int i = 0; i < numberSplit.Length; i++) 
        {
            if(int.TryParse(numberSplit[i], out int number))
            {
                if(number > max)
                {
                    max = number;
                }
                if (number < min) 
                {
                    min = number;
                }
            }
        }

        return $"{max} {min}";
    }


    public static string HighAndLowLinq(string numbers)
    {
        // Code here or
        var numSplitToIntList = numbers.Split(' ').Select(x => int.Parse(x));
        var max = numSplitToIntList.Max();
        var min = numSplitToIntList.Min();
        return $"{max} {min}";
    }

}