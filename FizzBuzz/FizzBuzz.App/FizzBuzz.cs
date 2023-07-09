namespace FizzBuzz.App;

public class FizzBuzz
{
    public IEnumerable<string> Play(int rounds)
    {
        var result = new List<string>();
        for (int i = 1; i <= rounds; i++)
        {
            var item = string.Empty;
            if (i % 3 == 0)
                item = "Fizz";
            if (i % 5 == 0)
                item += "Buzz";

            if (string.IsNullOrEmpty(item))
                item = i.ToString();
            result.Add(item);
        }

        return result;
    }
}
