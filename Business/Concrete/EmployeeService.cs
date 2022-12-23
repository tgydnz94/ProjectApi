using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee CreateEmployee(Employee employee)
        {
            if(employee != null) _employeeRepository.CreateEmployee(employee);
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            if (id > 0) _employeeRepository.DeleteEmployee(id);
            else new Exception("Silmek istediğiniz veriye ulaşılamadı.");
        }

        public List<Employee> GetAllEmployees()
        {
            return GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            if (id > 0) return _employeeRepository.GetEmployee(id);
            else throw new Exception("Veriye ulaşılamadı.");
        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (employee != null) return _employeeRepository.UpdateEmployee(employee);
            else throw new Exception("Güncellemek istediğiniz veri kullanılabilir bir veri değil.");
        }
    }
}
