namespace Yield;

class Yield
{
    static void Main() { 
        
        foreach (var i in ProduceEvenNumbers(9))
        {
            Console.Write(i);
            Console.Write(" ");
        }
        // Output: 0 2 4 6 8
        
        Console.WriteLine();

        IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }
        
        
        Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] {2, 3, 4, 5, -1, 3, 4})));
        // Output: 2 3 4 5

        Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] {9, 8, 7})));
        // Output: 9 8 7

        IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
        {
            foreach (var n in numbers)
            {
                if (n > 0)
                {
                    yield return n;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}