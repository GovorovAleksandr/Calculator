using Zenject;
using ModuleInstallation.Public;

namespace RequestBus.Installers
{
    public class Installer : IGlobalModuleInstaller, IPrioritizedModuleInstaller
    {
        public int Priority => -100;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<Core.RequestBus>().FromNew().AsSingle().NonLazy();
        }
    }
}