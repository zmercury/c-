namespace d_value_type_byte_signed;

class Program
{
    static void Main(string[] args)
    {
        sbyte a = 126;
        Console.WriteLine(a);

        a++;
        Console.WriteLine(a);

        // rolls back after 127 to -128
        a++;
        Console.WriteLine(a);
    }
}
