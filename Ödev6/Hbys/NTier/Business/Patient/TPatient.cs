using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient
{
    public struct TPatient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class TPatientProcess : IPatientProcess
    {
        private TPatient Patient;
        public TPatientProcess()
        {
            Patient = new TPatient();
        }
        public TPatientProcess(TPatient Patient)
        {
            this.Patient = Patient;
        }
        public bool AddNewPatient(TPatient Patient, out string OMessage, out long ONumber)
        {
            throw new NotImplementedException();
        }

        public List<TPatient> GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public List<TPatient> GetAllPatients(string Name)
        {
            throw new NotImplementedException();
        }

        public List<TPatient> GetAllPatients(long Number)
        {
            throw new NotImplementedException();
        }

        public bool RemovePatient(TPatient Patient, out string OMessage)
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatient(TPatient Patient, out string OMessage)
        {
            throw new NotImplementedException();
        }


    }


}

