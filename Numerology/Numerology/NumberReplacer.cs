namespace Numerology;

public class NumberReplacer
{
    public int[] Replace(int[] inputArray)
    {
        if (inputArray is [])
            return [];

        List<int> list = [];

        for (int i = 0; i < inputArray.Length; i++)
        {
            int n = inputArray[i];
            IEnumerable<int> replaced = n switch
            {
                9 => [10, 10],
                2 when i == 0 => [],
                2 => Enumerable.Repeat(1, inputArray[i - 1]),
                _ => [n]
            };

            list.AddRange(replaced);
        }

        return list.ToArray();
    }

    /*public int[] Replace2(int[] inputArray) =>
        inputArray.Select<int, int[]>(n => n == 9 ? [10, 10] : [n])
                  .SelectMany(n => n)
                  .ToArray();*/

}