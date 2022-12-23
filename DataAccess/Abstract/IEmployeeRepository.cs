using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee UpdateEmployee(Employee employee);

    }
}
