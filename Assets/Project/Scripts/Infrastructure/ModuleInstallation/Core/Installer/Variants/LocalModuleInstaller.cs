using System;
using ModuleInstallation.Public;
using UnityEngine.SceneManagement;

namespace ModuleInstallation.Core
{
    internal sealed class LocalModuleInstaller : ModuleInstaller<ILocalModuleEntry>
    {
        protected override bool CanBind(ILocalModuleEntry entry)
        {
            var bindingScenes = entry.BindingScenes;
            
            return
                bindingScenes.HasFlag(BindingScene.Any) ||
                bindingScenes.HasFlag(GetActiveSceneNameAsBindingScene());
        }
        
        private static BindingScene GetActiveSceneNameAsBindingScene() =>
            (BindingScene)Enum.Parse(typeof(BindingScene), GetActiveSceneName());
        
        private static string GetActiveSceneName() => SceneManager.GetActiveScene().name;
    }
}