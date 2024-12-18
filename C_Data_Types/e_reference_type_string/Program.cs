namespace e_reference_type_string;

class Program
{
    static void Main(string[] args)
    {
        string a = "Hello";

        a += "World";
        Console.WriteLine(a);

        a = a + "World";
        Console.WriteLine(a);        
    }
}
