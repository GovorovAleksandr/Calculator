using EventBusAutoRegistration.Core;
using ModuleInstallation.Public;
using Zenject;

namespace Events.Entry
{
    internal sealed class RegistrationEntry : ILocalModuleEntry, IPrioritizedModuleInstaller
    {
        public BindingScene BindingScenes => BindingScene.Any;

        public int Priority => 125;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<Registrator>().FromNew().AsSingle().NonLazy();
        }
    }
}