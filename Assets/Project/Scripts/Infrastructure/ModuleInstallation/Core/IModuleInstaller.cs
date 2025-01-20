using Zenject;

namespace ModuleInstallation.Core
{
    public interface IModuleInstaller
    {
        void InstallBindings(DiContainer container);
    }
}