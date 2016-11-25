using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolMVC2016.Models;

namespace TrendyolMVC2016.Services
{
    public interface IStorageService
    {
        List<Storage> GetAllStorages();
        Storage FindStorage(int? id);
    }
}
