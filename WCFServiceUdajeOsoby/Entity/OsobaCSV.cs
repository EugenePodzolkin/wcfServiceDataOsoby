using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceUdajeOsoby.Entity
{
    [DataContract]
    public class OsobaCSV
    {
        [DataMember]
        public string Meno { get; set; }
        [DataMember]
        public string Priezvisko { get; set; }
        [DataMember]
        public int Vek { get; set; }

        public OsobaCSV(){}
        public OsobaCSV(string Meno, string Priezvisko, int Vek)
        {
            this.Meno = Meno;
            this.Priezvisko = Priezvisko;
            this.Vek = Vek;
        }
    }
}
