using System;
using System.Collections.Generic;
using Business.Interfaces;
using Business.ViewModels;

namespace Business.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
        }

        public EmployeeViewModel Add(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel Edit(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeViewModel> Filter(EmployeeSearchViewModel search)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
