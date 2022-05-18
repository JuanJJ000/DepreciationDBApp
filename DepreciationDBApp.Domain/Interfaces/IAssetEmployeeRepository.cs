using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Domain.Interfaces
{
   public interface IAssetEmployeeRepository : IRepository<AssetEmployee>
    {

        List<AssetEmployee> FindByEmployeeId(int employeeId);

        AssetEmployee FindByAssetEmployeeId(int employeeId, int assetId);
        List<AssetEmployee> FindByAssetId(int assetId);
    }
}
