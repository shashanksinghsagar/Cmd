using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.PatientsService
{
    [ServiceContract]
    public interface IPatientService
    {

        [OperationContract]
        String Name(Patient patient);
         
       
    }
}
