namespace c_value_type_byte;

class Program
{
    static void Main(string[] args)
    {
        byte a = 0;

        Console.WriteLine(a);
        a++;
        Console.WriteLine(a);
        a=254;
        Console.WriteLine(a);
        a++;
        Console.WriteLine(a);
        // loops back to 0
        a++;
        Console.WriteLine(a);
    }
}
