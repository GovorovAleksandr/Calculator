using System;
using System.Linq;
using ModuleInstallation.Public;
using TypeFinding.Public;
using Zenject;

namespace ModuleInstallation.Core
{
    internal abstract class ModuleInstaller<T> : MonoInstaller where T : class, IModuleInstaller
    {
        protected virtual bool CanBind(T installer) => true;
        
        public override void InstallBindings()
        {
            if (!ChildTypeFinder.TryGetChildTypes(typeof(T), out var childTypes)) return;

            var installers = childTypes
                .Select(type => Activator.CreateInstance(type) as T).ToList();

            var sortedInstallers = installers.OrderBy(installer =>
            {
                var type = installer.GetType();
                if(type.GetInterface(nameof(IPrioritizedModuleInstaller)) == null) return 0;
                
                var prioritizedInstaller = (IPrioritizedModuleInstaller)installer;
                
                return prioritizedInstaller.Priority;
            }).ToList();
            
            foreach (var installer in sortedInstallers)
            {
                if (!CanBind(installer)) continue;
                installer.InstallBindings(Container);
            }
        }
    }
}