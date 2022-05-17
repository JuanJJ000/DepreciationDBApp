using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Infrastructure.Repositories
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        public IAssetEmployeeRepository assetEmployeeRepository;
        public IDepreciationDbContext depreciationDbContext;

        public EFEmployeeRepository(IDepreciationDbContext depreciationDbContext)
        {
            this.depreciationDbContext = depreciationDbContext;
        }

        public void Create(Employee t)
        {
            try
            {
                depreciationDbContext.Employees.Add(t);
                depreciationDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Employee t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Employee no puede ser null.");
                }

                Employee employee = FindByDni(t.Dni);
                if (employee == null)
                {
                    throw new Exception($"El objeto con dni {t.Dni} no existe.");
                }

                depreciationDbContext.Employees.Remove(employee);
                int result = depreciationDbContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Employee FindByDni(string dni)
        {
           try
            {
                if (string.IsNullOrWhiteSpace(dni))
                {
                    throw new Exception($"El parametro dni no tiene el formato correcto.");
                }

                return depreciationDbContext.Employees.FirstOrDefault(x => x.Dni.Equals(dni));
            }
            catch
            {
                throw;
            }
        }

        public Employee FindByEmail(string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    throw new Exception($"El parametro email  no tiene el formato correcto.");
                }

                return depreciationDbContext.Employees.FirstOrDefault(x => x.Email.Equals(email));
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Employee> FindByLastnames(string lastnames)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lastnames))
                {
                    throw new Exception($"El parametro lastname  no tiene el formato correcto.");
                }

                return depreciationDbContext.Employees
                                        .Where(x => x.Lastnames.Equals(lastnames, StringComparison.CurrentCultureIgnoreCase))
                                        .ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<Employee> GetAll()
        {
            try
            {

                return depreciationDbContext.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        public bool SetAssetToEmployee(Employee employee, Asset asset, DateTime effectiveDate)
        {
            try
            {
                ValidateEmployee(employee, asset);
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
            foreach (Asset asset in assets) 
            { 
            SetAssetToEmployee(employee, assets, effectiveDate); 
            }
            return true;
        }

        public int Update(Employee t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto employee no puede ser null.");
                }

                Employee employee = FindByDni(t.Dni);
                if (employee == null)
                {
                    throw new Exception($"El objeto eployee con dni {t.Dni} no existe.");
                }

                employee.Names = t.Names;
                employee.Lastnames = t.Lastnames;
           
                employee.Status = t.Status;
                employee.Address = t.Address;
                employee.Phone = t.Phone;
         

                depreciationDbContext.Employees
                    .Update(employee);
                return depreciationDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        private void ValidateEmployee(Employee employee, Asset asset)
        {


            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            if (asset == null)
            {
                throw new ArgumentNullException(nameof(asset));
            }
        }


    }
}
