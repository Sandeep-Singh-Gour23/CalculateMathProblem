namespace CalculateMathProblem.Service_Layer
{
    public interface IMathService
    {
        int add(int x, int y);
        int subtract(int x, int y);
        int multiply(int x, int y);
        double divide(double x, double y);
    }
}
