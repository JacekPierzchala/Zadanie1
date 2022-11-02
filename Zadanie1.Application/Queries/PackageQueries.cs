using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1.Core;
using Zadanie1.Infrastructure;

namespace Zadanie1.ApplicationLayer
{
    public class PackageQueries : IPackageQueries
    {
        private readonly IPackageRepository _packageRepository;

        public PackageQueries(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }
        public IEnumerable<PackageDTO> GetPackages()
        {
            var packagesFromDb = _packageRepository.GetPackages();
            var packages = new List<PackageDTO>();
            packagesFromDb.ToList()
                .ForEach(e => packages.Add(new PackageDTO
                {
                     Id=e.Id,
                     Name=e.Name, 
                      Description=e.Description,
                      Weight=e.Weight.ToString()
           
                      
                }));

            return packages;
        }
    }
}
