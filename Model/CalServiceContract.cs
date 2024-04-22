using System.ServiceModel;

namespace Calculator.Model
{
    public class CalServiceContract
    {
        [ServiceContract]
        public interface ICalService
        {
            [OperationContract]

            double add(double a, double b);

            [OperationContract]
            double sub(double a, double b);

            [OperationContract]

            double div(double a, double b);

            [OperationContract]

            double mul(double a, double b);
        }
    }
}