using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace DepreciationDBApp.Applications.Services
{
    public class EmployeeService : IEmployeeService
    {
        
        private IAssetEmployeeRepository assetEmployeeRepository;
        private IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IAssetEmployeeRepository assetEmployeeRepository)
        {
            this.employeeRepository = employeeRepository;
            this.assetEmployeeRepository = assetEmployeeRepository;
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
            try
            {
                ValidateAssetEmployee(employee, asset);
                AssetEmployee assetEmployee = new AssetEmployee()
                {
                    AssetId = asset.Id,
                    EmployeeId = employee.Id,
                    Date = effectiveDate,
                    IsActive = true
                };

                assetEmployeeRepository.Create(assetEmployee);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool SetAssetToEmployee(Employee employee, List<Asset> assets, DateTime effectiveDate)
        {
            bool success = false;
            try
            {
                if (assets == null || assets.Count == 0)
                {
                    throw new ArgumentNullException("La lista no puede estar vacia");
                }
                foreach (Asset asset in assets)
                {
                    success = SetAssetToEmployee(employee, asset, effectiveDate);
                    if (!success)
                    {
                        throw new Exception($"Fallo al asignar el asseId{asset.Id} al empleado {employee.Id}.");
                        //break;
                    }
                }

                //assets.ForEach(x =>
                //{
                //    SetAssetToEmployee(employee, x, efectiveDate);
                //});
                return success;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ValidateAssetEmployee(Employee employee, Asset asset)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            if (asset is null)
            {
                throw new ArgumentNullException(nameof(asset));
            }

            if (asset.Status.Equals("No disponible"))
            {
                //TODO: agregar los enums del status de activo y empleado
            }

            Employee employee1 = employeeRepository.FindByDni(employee.Dni);
            if (employee1 == null)
            {
                throw new ArgumentNullException($"El objeto {employee.Names} no existe");
            }
        }

        public int Update(Employee t)
        {
         return employeeRepository.Update(t);
        }


    }
}
