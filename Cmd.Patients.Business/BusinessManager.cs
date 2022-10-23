using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.Patients.Business
{
   public class BusinessManager
    {
        public String Name(Cmd.Patient.DTO.DTO dTO)
        {
            Cmd.Patients.Models.PatientModel patientModel = new Models.PatientModel();
            Cmd.Patients.Repository.DbManager dbManager = new Cmd.Patients.Repository.DbManager();

            return dbManager.Add(patientModel);


            
        }
    }
}
