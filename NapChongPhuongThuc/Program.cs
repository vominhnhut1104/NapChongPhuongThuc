namespace NapChong
{
    class Method
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return Sum(a, b) + c;
        }
        static int Sum(int a, int b, int c, int d)
        {
            return Sum(a, b, c) + d;
        }
        static float Sum(float a, float b)
        {
            return (float)a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(a, b));
        }
    }

}
