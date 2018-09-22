using System;
using System.Collections.Generic;
using Business.ViewModels;

namespace Business.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeViewModel Add(EmployeeViewModel employee);
        EmployeeViewModel Edit(EmployeeViewModel employee);
        EmployeeViewModel Remove(Guid id);
        EmployeeViewModel Get(Guid id);
        List<EmployeeViewModel> Filter(EmployeeSearchViewModel search);
    }
}
