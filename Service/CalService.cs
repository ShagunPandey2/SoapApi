using Calculator.Model;
using static Calculator.Model.CalServiceContract;

namespace Calculator.Service
{
    public class CalService: ICalService
    {
        public double add(double a, double b)
        {
            return a + b;
        }
       public double sub(double a, double b)
        {
            return a - b;

        }
        public double div(double a, double b)
        {
            return a / b;


        }

        public double mul(double a, double b)
        {
            return a * b;

        }

    }
   
}
