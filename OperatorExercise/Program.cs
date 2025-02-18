namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int difference = sum - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            PrintAreaOfCircle();
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the area of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 3)}");
        }
    }
}
