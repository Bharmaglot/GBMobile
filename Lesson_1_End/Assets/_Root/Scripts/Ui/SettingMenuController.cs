using Profile;
using Tool;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Ui
{
    internal class SettingMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/SettingMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly SettingMenuView _viewSetting;

        public SettingMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _viewSetting = LoadView(placeForUi);
            _viewSetting.Init(MainMenu);
         }

        private SettingMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObject(objectView);

            return objectView.GetComponent<SettingMenuView>();
        }

        private void MainMenu() =>
         _profilePlayer.CurrentState.Value = GameState.Start;
    }
}

