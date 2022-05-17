using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Interfaces
{
    public interface IEmployeeService : IService<Employee>
    {

        Employee FindByDni(string dni);

        Employee FindByEmail(string email);

        IEnumerable<Employee> FindByLastnames(string lastnames);

        bool SetAssetToEmployee(Employee employee, Asset asset, DateTime effectiveDate);

        bool SetAssetToEmployee(Employee employee, List<Asset> assets, DateTime effectiveDate);


    }
}
