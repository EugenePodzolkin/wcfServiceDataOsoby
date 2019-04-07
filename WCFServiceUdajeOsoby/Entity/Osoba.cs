using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceUdajeOsoby.Entity
{
    [Serializable]
    [DataContract]
    public class Osoba
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Meno { get; set; }
        [DataMember]
        public string Priezvisko { get; set; }
        [DataMember]
        public DateTime DatumNarodenia { get; set; }
        [DataMember]
        public AdresaOsoby Adresa { get; set; }

        public Osoba() { }
        public Osoba(int ID, string Meno, string Priezvisko, DateTime DatumNarodenia, AdresaOsoby Adresa)
        {
            this.ID = ID;
            this.Meno = Meno;
            this.Priezvisko = Priezvisko;
            this.DatumNarodenia = DatumNarodenia;
            this.Adresa = Adresa;
        }
    }
}
