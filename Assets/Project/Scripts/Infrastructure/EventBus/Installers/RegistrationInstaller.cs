using EventBusAutoRegistration.Core;
using Zenject;
using ModuleInstallation.Public;

namespace EventBusAutoRegistration.Installer
{
    internal sealed class RegistrationInstaller : ILocalModuleInstaller, IPrioritizedModuleInstaller
    {
        public BindingScene BindingScenes => BindingScene.Any;

        public int Priority => 125;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<Registrator>().FromNew().AsSingle().NonLazy();
        }
    }
}