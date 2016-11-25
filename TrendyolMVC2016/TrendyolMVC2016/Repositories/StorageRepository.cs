using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Repositories
{
    public class StorageRepository : IStorageRepository
    {
        private TrendyolContext _TrendyolDB;
        public StorageRepository(TrendyolContext TrendyolContext)
        {
            this._TrendyolDB = TrendyolContext;
        }

        public Storage FindStorage(int ?id)
        {
            return _TrendyolDB.Storages.Find(id);
        }

        public List<Storage> GetAllStorages()
        {
            var storages = _TrendyolDB.Storages.Include(s => s.Order);
            return storages.ToList();
        }
    }
}