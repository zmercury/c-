namespace f_reference_type_object;

class Program
{
    static void Main(string[] args)
    {
        object obj;
        obj = 45;

        Console.WriteLine(obj);
        Console.WriteLine(obj.GetType());
    }
}
