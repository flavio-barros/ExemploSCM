using System;
using System.Runtime.Serialization;

namespace ExemploSCM.Util
{   
    [DataContract]
    public class PontosGrafico
    {
        [DataMember(Name = "x")]
        public Nullable<int> X { get; set; }

        [DataMember(Name = "y")]
        public Nullable<int> Y { get; set; }
    }
}
 
