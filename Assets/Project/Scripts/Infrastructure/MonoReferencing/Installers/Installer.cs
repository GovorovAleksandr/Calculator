using ModuleInstallation.Public;
using MonoReferencing.Core;
using Zenject;

namespace MonoReferencing.Installers
{
    public class Installer : ILocalModuleInstaller, IPrioritizedModuleInstaller
    {
        public BindingScene BindingScenes => BindingScene.Any;

        public int Priority => 310;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<ReferenceInstaller>().FromNew().AsSingle().NonLazy();
        }
    }
}