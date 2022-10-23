using Cmd.Patient.DTO;
using Cmd.Patients.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.PatientsService
{
    
   
    public class PatientsServiceImp : IPatientService
    {
        public string Name(Patient patient)
        {
            BusinessManager businessManager = new BusinessManager();
            DTO dTO = new DTO();
            return businessManager.Name(dTO);
            
        }
    }
}
