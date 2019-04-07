using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using WCFServiceUdajeOsoby.Entity;

namespace WCFServiceUdajeOsoby
{
    public class Operations : IFileOperation, IDataOperation
    {
        public List<Osoba> GetDataFromXML()
        {
            List<Osoba> ArrayOfOsoba = new List<Osoba>();
            XmlSerializer formatter = new XmlSerializer(typeof(Osoba[]));

            using (FileStream fs = new FileStream("DataOsoby.xml", FileMode.OpenOrCreate))
            {                
                Osoba[] newPerson = (Osoba[])formatter.Deserialize(fs);
                foreach (Osoba osoba in newPerson)
                {
                    ArrayOfOsoba.Add(osoba);
                }
            }
            return ArrayOfOsoba;
        }

        public void WriteDataToCSV(List<Osoba> ArrayOfOsoba)
        {
            //string pathCsvFile = "DataOsoby.csv";
            DateTime tmpDate = DateTime.Now;
            string pathCsvFile = string.Format("DataOsoby" + tmpDate.Year + tmpDate.Month + tmpDate.Day + tmpDate.Hour + tmpDate.Minute + tmpDate.Second + ".csv");
            StringBuilder csvContent = new StringBuilder();

            foreach (Osoba osoba in ArrayOfOsoba)
            {
                OsobaCSV osobaCSV = new OsobaCSV(osoba.Meno, osoba.Priezvisko, Years(osoba.DatumNarodenia));
                string newLine = string.Format("{0},{1},{2}", osobaCSV.Meno, osobaCSV.Priezvisko, osobaCSV.Vek);
                csvContent.AppendLine(newLine);
            }
            File.WriteAllText(pathCsvFile, csvContent.ToString());
        }

        public List<Osoba> GetLessAge(List<Osoba> ArrayOfOsoba, int age)
        {
            List<Osoba> OsobaPreCSV = new List<Osoba>();
            foreach (Osoba osoba in ArrayOfOsoba)
            {
                if (age > Years(osoba.DatumNarodenia))
                {
                    OsobaPreCSV.Add(osoba);
                }
            }
            return OsobaPreCSV;
        }

        private int Years(DateTime birthday)
        {
            DateTime end = DateTime.Today;
            return (end.Year - birthday.Year - 1) + (((end.Month > birthday.Month) ||
                ((end.Month == birthday.Month) && (end.Day >= birthday.Day))) ? 1 : 0);
        }
    }
}
