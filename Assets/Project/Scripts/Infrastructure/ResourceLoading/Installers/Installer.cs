using Zenject;
using ModuleInstallation.Public;

namespace ResourceLoading.Installers
{
    internal sealed class Installer : ILocalModuleInstaller, IPrioritizedModuleInstaller
    {
        public BindingScene BindingScenes => BindingScene.Any;

        public int Priority => 300;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<ResourceLoader>().FromNew().AsSingle().NonLazy();
        }
    }
}