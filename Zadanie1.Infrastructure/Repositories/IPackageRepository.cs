using Zadanie1.Core;

namespace Zadanie1.Infrastructure
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetPackages();
        void Update(IEnumerable<Package> packages);
    }
}