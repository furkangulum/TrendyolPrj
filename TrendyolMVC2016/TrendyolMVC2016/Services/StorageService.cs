using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendyolMVC2016.Models;
using TrendyolMVC2016.Repositories;

namespace TrendyolMVC2016.Services
{
    public class StorageService : IStorageService
    {
        private IStorageRepository _IStorageRepository;
        public StorageService(IStorageRepository IstoreRepository)
        {
            this._IStorageRepository = IstoreRepository;
        }

        public Storage FindStorage(int? id)
        {
            return _IStorageRepository.FindStorage(id);
        }

        public List<Storage> GetAllStorages()
        {
            return _IStorageRepository.GetAllStorages();
        }
    }
}