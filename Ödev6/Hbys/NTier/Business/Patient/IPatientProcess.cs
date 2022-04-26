using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient
{
    public interface IPatientProcess
    {
        bool AddNewPatient(TPatient Patient, out string OMessage, out long ONumber);
        bool RemovePatient(TPatient Patient, out string OMessage);
        bool UpdatePatient(TPatient Patient, out string OMessage);
        List<TPatient> GetAllPatients();
        List<TPatient> GetAllPatients(string Name);
        List<TPatient> GetAllPatients(long Number);

    }
}
