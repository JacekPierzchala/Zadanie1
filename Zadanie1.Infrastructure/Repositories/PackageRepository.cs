using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1.Core;

namespace Zadanie1.Infrastructure
{
    public class PackageRepository : IPackageRepository
    {
        private readonly DatabaseHandler _databaseHandler;

        public PackageRepository(DatabaseHandler databaseHandler)
        {
            _databaseHandler = databaseHandler;
        }

        public IEnumerable<Package> GetPackages()
        {
            return _databaseHandler.Db.Table<Package>();
        }

        public void Update(IEnumerable<Package> packages)
        {
         
            _databaseHandler.Db.UpdateAll(packages);
            _databaseHandler.Db.InsertAll(packages.Where(e=>e.Id==0).ToList());
        }
    }
}
