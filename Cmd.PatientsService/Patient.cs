using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.PatientsService
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public string Name { get; set; } 
    }
}
