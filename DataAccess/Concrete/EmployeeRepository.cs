using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ProjectContext _context;

        public EmployeeRepository(ProjectContext context)
        {
            _context = context;

        }


        public Employee CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            var deleted = GetEmployee(id);
            _context.Employees.Remove(deleted);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            Employee updated = GetEmployee(employee.ID);
            updated.FirstName = employee.FirstName;
            updated.LastName = employee.LastName;
            updated.Department = employee.Department;
            _context.SaveChanges();

            return employee;

        }
    }
}
