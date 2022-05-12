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
