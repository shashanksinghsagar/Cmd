using Cmd.PatientsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri( "http://localhost:8733/Design_Time_Addresses/Cmd.PatientsService/Service1/");
            using (ServiceHost serviceHost = new ServiceHost(typeof(PatientsServiceImp)))
            {
                serviceHost.Open();
                testNS.PatientServiceClient patientServiceClient = new testNS.PatientServiceClient();
                Cmd.PatientsService.Patient patient = new Cmd.PatientsService.Patient();

               Console.WriteLine(patientServiceClient.Name(patient));
            }
                //Cmd.PatientsService.PatientsServiceImp patientsServiceImp = new Cmd.PatientsService.PatientsServiceImp();
           

        }
    }
}
