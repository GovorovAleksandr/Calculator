using Calculation.Core.Calculator.Model;
using Calculation.Core.Calculator.Persistence;
using Calculation.Core.Calculator.Validation;
using Calculation.Core.Calculator.View;
using Calculation.Core.InputParser;
using Calculation.Core.Presentation;
using Calculation.Core.View;
using ModuleInstallation.Public;
using Zenject;

namespace Calculation.Entry
{
    internal sealed class Entry : ILocalModuleEntry
    {
        public BindingScene BindingScenes => BindingScene.Gameplay;

        public void InstallBindings(DiContainer container)
        {
            container.BindInterfacesTo<CalculatorInput>().FromNew().AsSingle().NonLazy();
            container.BindInterfacesTo<CalculatorInputValidator>().FromNew().AsSingle().NonLazy();
            container.BindInterfacesTo<InputParser>().FromNew().AsSingle().NonLazy();
            
            container.BindInterfacesTo<Calculator>().FromNew().AsSingle().NonLazy();
            
            container.BindInterfacesTo<CalculatorPresenter>().FromNew().AsSingle().NonLazy();
            
            container.BindInterfacesTo<ResultView>().FromNew().AsSingle().NonLazy();
            container.BindInterfacesTo<PopupView>().FromNew().AsSingle().NonLazy();
            
            container.BindInterfacesTo<CalculatorStatePreserver>().FromNew().AsSingle().NonLazy();
            container.BindInterfacesTo<CalculatorStateLoader>().FromNew().AsSingle().NonLazy();
        }
    }
}