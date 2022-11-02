namespace Zadanie1.ApplicationLayer
{
    public interface IPackageCommands
    {
        void UpdatePackages(IEnumerable<PackageDTO> packagesDTO);
    }
}