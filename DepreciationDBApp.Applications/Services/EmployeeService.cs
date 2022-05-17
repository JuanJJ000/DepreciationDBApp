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
            employeeRepository.Create(t);
        }

        public bool Delete(Employee t)
        {
            return employeeRepository.Delete(t);
        }

        public Employee FindByDni(string dni)
        {
            return employeeRepository.FindByDni(dni);
        }

        public Employee FindByEmail(string email)
        {
            return employeeRepository.FindByEmail(email);
        }

        public IEnumerable<Employee> FindByLastnames(string lastnames)
        {
            return employeeRepository.FindByLastnames(lastnames);
        }

        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public bool SetAssetToEmployee(Employee employee, Asset asset, DateTime effectiveDate)
        {
            return employeeRepository.SetAssetToEmployee(employee, asset, effectiveDate);
        }

        public bool SetAssetToEmployee(Employee employee, List<Asset> assets, DateTime effectiveDate)
        {
            return employeeRepository.SetAssetToEmployee(employee, assets,effectiveDate);
        }


        public int Update(Employee t)
        {
         return employeeRepository.Update(t);
        }


    }
}
