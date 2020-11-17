﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Library
{
    public class ManagerAccounts : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acmecorp.com";

            output.IsManager = true;

            return output;
        }
    }
}
