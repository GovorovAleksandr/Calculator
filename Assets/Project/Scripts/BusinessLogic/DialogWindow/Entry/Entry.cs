using DialogWindow.Core;
using ModuleInstallation.Public;
using Zenject;

namespace DialogWindow
{
    internal sealed class Entry : ILocalModuleEntry
    {
        public BindingScene BindingScenes => BindingScene.Gameplay;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<DialogBoxDisplayer>().FromNew().AsSingle().NonLazy();
        }
    }
}