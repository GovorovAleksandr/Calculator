namespace ModuleInstallation.Public
{
    public interface IPrioritizedModuleInstaller
    {
        int Priority { get; }
    }
}