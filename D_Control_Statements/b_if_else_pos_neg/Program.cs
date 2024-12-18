namespace b_if_else_pos_neg;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        
        int num = Convert.ToInt32(Console.ReadLine());

        if(num > 0) {
            Console.WriteLine("The number is positive");
        } else {
            Console.WriteLine("The number is negative");
        }
    }
}
