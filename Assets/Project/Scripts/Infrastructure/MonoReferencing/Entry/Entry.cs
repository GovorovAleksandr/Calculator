using ModuleInstallation.Public;
using MonoReferencing.Core;
using Zenject;

namespace MonoReferencing.Installers
{
    internal sealed class Entry : ILocalModuleEntry, IPrioritizedModuleInstaller
    {
        public BindingScene BindingScenes => BindingScene.Any;

        public int Priority => 310;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<ReferenceInstaller>().FromNew().AsSingle().NonLazy();
        }
    }
}