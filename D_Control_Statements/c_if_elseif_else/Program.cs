namespace c_if_elseif_else;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        
        int num = Convert.ToInt32(Console.ReadLine());

        if(num == 0) {
            Console.WriteLine("The number is zero");
        } else if (num > 0) {
            Console.WriteLine("The number is positive");
        } else {
            Console.WriteLine("The number is negative");
        }
    }
}