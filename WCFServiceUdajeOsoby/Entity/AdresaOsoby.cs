using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceUdajeOsoby.Entity
{
    //[Serializable]
   // [DataContract]
    public class AdresaOsoby
    {
        [DataMember]
        public string Ulica { get; set; }
        [DataMember]
        public int Cislo { get; set; }

        public AdresaOsoby() { }
        public AdresaOsoby(string Ulica, int Cislo)
        {
            this.Ulica = Ulica;
            this.Cislo = Cislo;
        }
    }
}
