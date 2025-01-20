using ModuleInstallation.Core;

namespace ModuleInstallation.Public
{
    public interface ILocalModuleEntry : IModuleInstaller
    {
        BindingScene BindingScenes { get; }
    }
}