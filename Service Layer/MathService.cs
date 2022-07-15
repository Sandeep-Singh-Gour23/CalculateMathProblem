namespace CalculateMathProblem.Service_Layer
{
    public class MathService : IMathService
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtract(int x, int y)
        {
            return x - y;
        }
        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int divide(int x, int y)
        {
            return x / y;
        }
    }
}
