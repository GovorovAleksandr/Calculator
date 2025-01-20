using ModuleInstallation.Core;

namespace ModuleInstallation.Public
{
    public interface ILocalModuleInstaller : IModuleInstaller
    {
        BindingScene BindingScenes { get; }
    }
}