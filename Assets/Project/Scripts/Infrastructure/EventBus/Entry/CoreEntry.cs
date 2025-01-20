using EventBus.Core;
using ModuleInstallation.Public;
using Zenject;

namespace EventBus.Entry
{
    internal sealed class CoreEntry : IGlobalModuleInstaller, IPrioritizedModuleInstaller
    {
        public int Priority => -100;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<Core.EventBus>().FromNew().AsSingle().NonLazy();
            container.BindInterfacesTo<GenericEventSender>().FromNew().AsSingle().NonLazy();
        }
    }
}