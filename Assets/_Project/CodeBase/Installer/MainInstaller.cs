using _Project.CodeBase.QuizMechanics;
using _Project.CodeBase.UI;
using _Project.CodeBase.Utils;
using CodeBase.Card;
using CodeBase.Grid;
using CodeBase.Level;
using UnityEngine;
using Zenject;

namespace _Project.CodeBase.Installer
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private LevelData _levelData;
        
        [Header("Prefabs")]
        [SerializeField] private CustomGridLayout _gridLayout;
        [SerializeField] private Card _cardPrefab;
        [SerializeField] private TaskView _taskView;
        [SerializeField] private EndGameView _endGameView;
        
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameLoop>()
                .AsSingle()
                .WithArguments(_endGameView);

            Container.Bind<CardPackFactory>()
                .AsSingle()
                .WithArguments(_cardPrefab);
            
            Container.Bind<LevelData>()
                .FromScriptableObject(_levelData)
                .AsSingle();
            
            Container.BindInterfacesAndSelfTo<AnswerListener>().AsSingle();
            Container.Bind<UniqueAnswerService>().AsSingle();

            Container.Bind<CustomGridLayout>()
                .FromComponentInNewPrefab(_gridLayout)
                .WithGameObjectName("GridLayout")
                .AsSingle()
                .NonLazy();

            Container.Bind<LevelCreator>().AsSingle();
            
            Container.Bind<TaskView>()
                .FromComponentInNewPrefab(_taskView)
                .WithGameObjectName("UITextAnimator")
                .AsSingle();

            Container.Bind<Coroutines>()
                .FromNewComponentOnNewGameObject()
                .WithGameObjectName("[Coroutines]")
                .AsSingle();
        }
    }
}