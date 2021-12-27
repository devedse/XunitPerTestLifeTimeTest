namespace XunitPerTestLifeTimeTest
{
    public class Calculator
    {
        public int OperationsDone { get; private set; }

        public int Sum(int a, int b)
        {
            OperationsDone++;
            var res = a + b;
            Console.WriteLine($"{a} + {b} = {res}");
            return res;
        }

        public int Subtract(int a, int b)
        {
            OperationsDone++;
            var res = a - b;
            Console.WriteLine($"{a} - {b} = {res}");
            return res;
        }

        public int Multiply(int a, int b)
        {
            OperationsDone++;
            var res = a * b;
            Console.WriteLine($"{a} * {b} = {res}");
            return res;
        }

        public int Divide(int a, int b)
        {
            OperationsDone++;
            var res = a / b;
            Console.WriteLine($"{a} / {b} = {res}");
            return res;

        }
    }
}
