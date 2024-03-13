namespace Project;

class Finder
{
    static void Main()
    {
        String [] myArr = {"Hello", "2", "world", ":-)"};
        printArray (myArr);
        Console.WriteLine("");
        printArray (createArrayWithLengthOfThreeChar(myArr));
    }
    static void printArray (String[] array)
    {
        Console.Write("[");
        for (int i = 0;i < array.Length;i ++) {
            Console.Write(array[i]);
            if (i < array.Length - 1) 
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
    }

}