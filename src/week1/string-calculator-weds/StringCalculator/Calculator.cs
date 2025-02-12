public class Calculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var numberArray = numbers.Split(',');
        int sum = 0;

        foreach (var number in numberArray)
        {
            sum += int.Parse(number);
        }

        return sum;
    }
}