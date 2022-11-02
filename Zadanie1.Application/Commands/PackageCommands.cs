using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1.Core;
using Zadanie1.Infrastructure;

namespace Zadanie1.ApplicationLayer
{
    public class PackageCommands : IPackageCommands
    {
        private readonly IPackageRepository _packageRepository;

        public PackageCommands(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public void UpdatePackages(IEnumerable<PackageDTO> packagesDTO)
        {
            var packagesToUpdate = new List<Package>();
            packagesDTO.ToList().ForEach(e => packagesToUpdate.Add(new Package
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                Weight = e.Weight !=null? double.Parse(e.Weight):0

            })); ;
            _packageRepository.Update(packagesToUpdate);
        }
    }
}
