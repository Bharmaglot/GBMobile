using Profile;
using Tool;
using UnityEngine;

namespace Ui
{
    internal class GoToMainMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/Ui/GoToMainMenu");

        private readonly GoToMainMenuView _view;
        private readonly ProfilePlayer _profilePlayer;


        public GoToMainMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(GoToMainMenu);
        }

        private GoToMainMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObject(objectView);

            return objectView.GetComponent<GoToMainMenuView>();
        }

        public void GoToMainMenu() => _profilePlayer.CurrentState.Value = GameState.Start;
    }
}