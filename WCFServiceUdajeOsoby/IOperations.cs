using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceUdajeOsoby.Entity;

namespace WCFServiceUdajeOsoby
{
    [ServiceContract]
    public interface IFileOperation
    {
        [OperationContract]
        List<Osoba> GetDataFromXML();

        [OperationContract]
        void WriteDataToCSV(List<Osoba> ArrayOfOsoba);
    }

    [ServiceContract]
    public interface IDataOperation
    {
        [OperationContract]
        List<Osoba> GetLessAge(List<Osoba> ArrayOfOsoba, int age);
    }
}
