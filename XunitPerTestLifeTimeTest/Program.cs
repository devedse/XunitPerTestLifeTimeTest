namespace XunitPerTestLifeTimeTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Testing calculator:");
            CalcThings(59, 12);
        }

        public static void CalcThings(int a, int b)
        {
            var calc = new Calculator();
            calc.Sum(a, b);
            calc.Subtract(a, b);
            calc.Multiply(a, b);
            calc.Divide(a, b);
        }
    }
}