using System.Collections;

class Program
{
    static void Main()
    {
        // int someNumber = 420; 
        // object someNumberObject = someNumber; //boxing
        // int unbox = (int)someNumberObject; // unboxing

        var arrayOfInts = Enumerable.Range(69, 420).ToArray();
        var arrayList = new ArrayList(arrayOfInts);
        var list = new List<int>(arrayOfInts);

    }
}