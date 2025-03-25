using HMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Specifications.Patients
{
    public class PatientSpecification : BaseSpecification<Patient>
    {
        public PatientSpecification()
            : base(p => p.IsActive)
        {
            AddIncludes();
        }

        public PatientSpecification(int id)
            : base(p => p.Id == id && p.IsActive)
        {
            AddIncludes();
        }

        private void AddIncludes()
        {
            Includes.Add(p => p.InsuranceCompany);
            Includes.Add(p => p.InsuranceCategory);
        }
    }
}
