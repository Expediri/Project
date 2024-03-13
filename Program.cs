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
    static String[] createArrayWithLengthOfThreeChar (String[] array)
    {
        String[] arrayOfThreeChar = new String[0];
        for (int i = 0;i < array.Length;i ++)
        {
            if (array[i].Length<=3)
            {
                Array.Resize(ref arrayOfThreeChar, arrayOfThreeChar.Length + 1);
                arrayOfThreeChar [arrayOfThreeChar.Length - 1] = array [i];
            }
        }
        return arrayOfThreeChar;
    }
}