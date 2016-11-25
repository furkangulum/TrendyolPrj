using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Repositories
{
    public interface IStorageRepository
    {
        List<Storage> GetAllStorages();
        Storage FindStorage(int ?id);
        void AcceptOrders(int[] arr);
    }
}
