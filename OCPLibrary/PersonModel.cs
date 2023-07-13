using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    // ctrl + . ===> Extract Interface to implement OCP
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
        //public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
    }
}
