﻿using Cloud.Magasin.Core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Magasin.Core
{
    public interface IDbClient
    {
        IMongoCollection<Phone> GetPhoneCollection();
        IMongoCollection<Tablet> GetTabletCollection();
        IMongoCollection<Computer> GetComputerCollection();
    }
}
