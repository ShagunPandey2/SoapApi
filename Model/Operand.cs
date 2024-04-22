using System.Runtime.Serialization;

namespace Calculator.Model
{
    [DataContract]
    public class Operand
    {
        [DataMember]
        public int Operand1 { get; set; }

        [DataMember]
        public int Operand2 { get; set; }
        
    }

}
