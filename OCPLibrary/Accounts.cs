using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            return output;


            // violating ocp, modifying method
            //if (person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    output.IsManager = true;
            //}
            //if (person.TypeOfEmployee == EmployeeType.Executive)
            //{
            //    output.IsExecutive = true;
            //}

            //switch (person.TypeOfEmployee)
            //{
            //    case EmployeeType.Manager:
            //        output.IsManager = true;
            //        break;
            //    case EmployeeType.Staff:

            //        break;
            //    case EmployeeType.Executive:
            //        output.IsExecutive = true;
            //        output.IsManager = true;
            //        break;
            //}
            //return output;
        }


    }
}
