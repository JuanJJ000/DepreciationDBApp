﻿using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Infrastructure.Repositories
{
    public class AssetEmployeeRepository : IAssetEmployeeRepository
    {
        public void Create(AssetEmployee t)
        {
         
            


        }

        public bool Delete(AssetEmployee t)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByAssetId(int assetId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(AssetEmployee t)
        {
            throw new NotImplementedException();
        }
    }
}