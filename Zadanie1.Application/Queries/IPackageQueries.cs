using Zadanie1.Core;

namespace Zadanie1.ApplicationLayer
{
    public interface IPackageQueries
    {
        IEnumerable<PackageDTO> GetPackages();
    }
}