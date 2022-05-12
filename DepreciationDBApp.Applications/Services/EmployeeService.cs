using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Services
{
   public class EmployeeService : IEmployeeService
    {

        private IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void Create(Employee t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee t)
        {
            throw new NotImplementedException();
        }

        public Employee FindByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public Employee FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> FindByLastnames(string lastnames)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
